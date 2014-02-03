﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using OccuRec.Drivers.AAVTimer.VideoCaptureImpl;
using OccuRec.Tracking;
using OccuRec.Utilities;

namespace OccuRec.Helpers
{
    public class NTPClient
    {
        // http://stackoverflow.com/questions/1193955/how-to-query-an-ntp-server-using-c
        public static DateTime GetNetworkTime(string ntpServer, out float latencyInMilliseconds)
        {
	        NTPTimeKeeper.AttemptingNTPTimeUpdate();

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);
	        long startTicks = 0;
			long endTicks = 0;
			long clockFrequency = 0;
            latencyInMilliseconds = 0;

			Profiler.QueryPerformanceFrequency(ref clockFrequency);

            Profiler.QueryPerformanceCounter(ref startTicks);
            socket.Send(ntpData);
	        socket.ReceiveTimeout = 3000;
			try
			{
				socket.Receive(ntpData);

				Profiler.QueryPerformanceCounter(ref endTicks);

				latencyInMilliseconds += (endTicks - startTicks) * 1000.0f / clockFrequency;
			}
			catch (SocketException sex)
			{
				Trace.WriteLine(sex.GetFullStackTrace());

				// http://msdn.microsoft.com/en-us/library/windows/desktop/ms740668(v=vs.85).aspx
				if (sex.ErrorCode == 995 || /* WSA_OPERATION_ABORTED 995 */
				    sex.ErrorCode == 10060 /* WSAETIMEDOUT 10060 */)
				{
					latencyInMilliseconds = float.NaN;
				}
				else
					throw;
			}

            socket.Close();

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            ulong milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
			DateTime networkDateTime = (new DateTime(1900, 1, 1)).AddMilliseconds((long)milliseconds);

			NTPTimeKeeper.ProcessNTPResponce(startTicks, endTicks, clockFrequency, networkDateTime);

            return networkDateTime;
        }

        // stackoverflow.com/a/3294698/162671
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);


        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;
        }

        public static void SetTime(DateTime newUtcTime)
        {
            // Call the native GetSystemTime method 
            // with the defined structure.
            SYSTEMTIME systime = new SYSTEMTIME();
            GetSystemTime(ref systime);

            systime.wYear = (ushort)newUtcTime.Year;
            systime.wMonth = (ushort)newUtcTime.Month;
            systime.wDay = (ushort)newUtcTime.Day;
            systime.wHour = (ushort)newUtcTime.Hour;
            systime.wMinute = (ushort)newUtcTime.Minute;
            systime.wSecond = (ushort)newUtcTime.Second;
            systime.wMilliseconds = (ushort)newUtcTime.Millisecond;

            SetSystemTime(ref systime);
        }
    }

	public class NTPTimeKeeper
	{
		private static long s_ReferenceTicks = -1;
		private static long s_ReferenceDateTimeTicks = -1;
		private static long s_FirstReferenceTicks = long.MaxValue;
		private static long s_FirstReferenceDateTimeTicks = -1;
		private static DateTime s_ReferenceDateTime;
		private static long s_ReferenceFrequency = -1;
		private static long s_ReferenceMaxError = -1;

		private static DateTime s_FirtstAttemptedDateTimeUpdate = DateTime.MinValue;
		private static long s_NumberDateTimeUpdateAttempts = 0;

		public static void AttemptingNTPTimeUpdate()
		{
			s_NumberDateTimeUpdateAttempts++;

			if (s_FirtstAttemptedDateTimeUpdate == DateTime.MinValue)
				s_FirtstAttemptedDateTimeUpdate = DateTime.UtcNow;
		}

		public static void ProcessNTPResponce(long startTicks, long endTicks, long frequency, DateTime utcTime)
		{
            long maxError = (long)(0.5 + (endTicks - startTicks) * 1000.0f / frequency);
		    if (maxError <= 0) return;

			long currTicks = startTicks + (maxError / 2);

			if (s_ReferenceFrequency != frequency || s_FirstReferenceTicks > currTicks)
			{
				// This is the first measurement
				UpdateTimeReference(currTicks, frequency, utcTime, maxError);
				if (s_ReferenceFrequency != frequency)
					Trace.WriteLine(string.Format("OccuRec: First time reference set. Max error is {0}ms.", s_ReferenceMaxError.ToString("0.0")));
				else
					Trace.WriteLine(string.Format("OccuRec: Reference is set after QPC overflow. Max error is {0}ms.", s_ReferenceMaxError.ToString("0.0")));
			}
			else
			{
				if (maxError < s_ReferenceMaxError)
				{
					Trace.WriteLine(string.Format("OccuRec: Time reference updated. Current measurement's error of {0}ms is smaller that the last reference's error of {1}ms.", maxError.ToString("0.0"), s_ReferenceMaxError.ToString("0.0")));
					UpdateTimeReference(currTicks, frequency, utcTime, maxError);
				}
				else
				{
					double tsSinceFirstReference = new TimeSpan(utcTime.Ticks - s_FirstReferenceDateTimeTicks).TotalMinutes;
					if (tsSinceFirstReference > 10)
					{
						double totalPassedMinutesNTP = ((currTicks - s_FirstReferenceTicks) * 1000.0f / frequency) / 60000;
						double sectionRatio = 1.0 * (utcTime.Ticks - s_ReferenceDateTimeTicks)/(utcTime.Ticks - s_FirstReferenceDateTimeTicks);
						double timeDriftMilleseconds = sectionRatio * Math.Abs(totalPassedMinutesNTP - tsSinceFirstReference)*60000;
						if (totalPassedMinutesNTP > 0 && timeDriftMilleseconds > (maxError / 2.0))
						{
							UpdateTimeReference(currTicks, frequency, utcTime, maxError);
							Trace.WriteLine(string.Format("OccuRec: Time reference updated. Current timedrift, since last reference update, or {0}ms +/- half max error is bigger than the max error of {1}ms.", timeDriftMilleseconds.ToString("0,0"), maxError.ToString("0.0")));
						}
					}
				}
			}
		}

		public static Color GetCurrentNTPStatusColour(out string statusMessage)
		{
			// If there is no first reference set and OccuRec has been started for more than 1 min, this is status Red  
			if (s_FirtstAttemptedDateTimeUpdate > DateTime.MinValue && 				
			    s_FirstReferenceTicks == long.MaxValue)
			{
				double secondsSinceFirstTimeUpdateAttempt = new TimeSpan(DateTime.UtcNow.Ticks - s_FirtstAttemptedDateTimeUpdate.Ticks).TotalSeconds;

				if (secondsSinceFirstTimeUpdateAttempt > 60)
				{
					statusMessage = "NTP time has been never updated. Check your internet connection and NTP server settings.";
					return Color.Red;
				}
				else
				{
					// This is how we tell that no NTP status is yet known
					statusMessage = null;
					return SystemColors.Control;					
				}
			}

			// If the current error is bigger then 1 sec then this is status Red
			if (s_ReferenceMaxError > 1000)
			{
				statusMessage = "Current NTP time error is larger than 1 sec.";
				return Color.Red;
			}
			
			// If the current error is between 250ms and 1 sec this is status OrangeRed
			if (s_ReferenceMaxError > 250)
			{
				statusMessage = "Current NTP time error is larger than 250 ms but smaller than 1 sec.";
				return Color.OrangeRed;
			}


			// If the current error is between 100ms and 250ms this is status DarkGoldenrod
			if (s_ReferenceMaxError > 100)
			{
				statusMessage = "Current NTP time error is larger than 100 ms but smaller than 250 ms.";
				return Color.DarkGoldenrod;
			}

			// If the interval between the first reference and now is more than 5 min and curent error is less than 100ms, this is status Green
			if (s_ReferenceMaxError <= 100)
			{
				statusMessage = "Current NTP time error is smaller than 100 ms.";
				return Color.Green;
			}

			statusMessage = null;
			return SystemColors.Control;
		}

		private static void UpdateTimeReference(long currTicks, long frequency, DateTime utcTime, long maxError)
		{
			s_ReferenceFrequency = frequency;
			s_ReferenceTicks = currTicks;
			s_ReferenceDateTime = utcTime;
			s_ReferenceDateTimeTicks = utcTime.Ticks;
			s_ReferenceMaxError = maxError;

			if (s_FirstReferenceTicks > s_ReferenceTicks)
			{
				s_FirstReferenceTicks = s_ReferenceTicks;
				s_FirstReferenceDateTimeTicks = s_ReferenceDateTimeTicks;
			}
		}

		public static DateTime UtcNow(out double maxErrorMilliseconds)
		{
			if (s_ReferenceFrequency > 0)
			{
				long ticksNow = 0;
				Profiler.QueryPerformanceCounter(ref ticksNow);
				double millsecondsFromReferenceFrame = (ticksNow - s_ReferenceTicks)*1000.0f/s_ReferenceFrequency;
				maxErrorMilliseconds = s_ReferenceMaxError;
				return s_ReferenceDateTime.AddMilliseconds(millsecondsFromReferenceFrame);
			}
			else
			{
				maxErrorMilliseconds = 60*1000;
				return DateTime.UtcNow;
			}
		}
	}
}
