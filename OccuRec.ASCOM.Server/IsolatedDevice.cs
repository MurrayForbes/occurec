﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using ASCOM.DriverAccess;
using OccuRec.ASCOM.Interfaces.Devices;

namespace OccuRec.ASCOM.Server
{
	[Serializable]
	public class IsolatedDevice : MarshalByRefObject, IASCOMDevice, IDisposable
	{
		protected AscomDriver m_Device;

		public string ProgId { get; private set; }

		public Guid UniqueId { get; private set; }

		protected void SetIsolatedDevice(AscomDriver device, string progId)
		{
			m_Device = device;
			ProgId = progId;
			UniqueId = Guid.NewGuid();
		}

		public bool Connected
		{
			get { return m_Device.Connected; }
			set
			{
			    m_Device.Connected = value;
                Trace.WriteLine(string.Format("OccuRec: ASCOMServer::{0}::Connected = {1}", ProgId, value));
			}
		}

		public string Description
		{
			get { return m_Device.Description; }
		}

		public string DriverVersion
		{
			get { return m_Device.DriverVersion; }
		}

		protected virtual void Dispose(bool disposing)
		{
			m_Device.Connected = false;
			m_Device.Dispose();

            Trace.WriteLine(string.Format("OccuRec: ASCOMServer::{0}::Dispose()", ProgId));

		    RemotingServices.Disconnect(this);
		}

		public void Dispose()
		{
			Dispose(true);
		}
	}
}
