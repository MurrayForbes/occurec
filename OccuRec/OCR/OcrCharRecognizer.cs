﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OccuRec.OCR
{
    public class OcrCharRecognizer
    {
        public static int MIN_ON_VALUE = 200;
		public static int MAX_OFF_VALUE = 80;

        private List<OcrZone> zones = new List<OcrZone>();
        private List<CharDefinition> charDefinitions = new List<CharDefinition>();

        public OcrCharRecognizer(List<OcrZone> zones, List<CharDefinition> charDefinitions)
        {
            this.zones.AddRange(zones);
            this.charDefinitions.AddRange(charDefinitions);
        }

		public char RecognizeCharSplitZones(double[] computedZonesTop, double[] computedZonesBottom, int charPosition)
		{
			foreach (CharDefinition charDef in charDefinitions)
			{
				if (charDef.FixedPosition != null &&
					charDef.FixedPosition.Value != charPosition)
				{
					continue;
				}

				bool isMatch = true;

				foreach (ZoneSignature zoneSign in charDef.ZoneSignatures)
				{
					bool isOnOff = computedZonesTop[zoneSign.ZoneId] >= MIN_ON_VALUE && computedZonesBottom[zoneSign.ZoneId] < MAX_OFF_VALUE;
					bool isOffOn = computedZonesTop[zoneSign.ZoneId] < MAX_OFF_VALUE && computedZonesBottom[zoneSign.ZoneId] >= MIN_ON_VALUE;

					if (zoneSign.ZoneValue == ZoneValue.OnOff && !isOnOff)
					{
						isMatch = false;
						break;
					}

					if (zoneSign.ZoneValue == ZoneValue.OffOn && !isOffOn)
					{
						isMatch = false;
						break;
					}

					if (zoneSign.ZoneValue == ZoneValue.NotOffOn && isOffOn)
					{
						isMatch = false;
						break;
					}

					if (zoneSign.ZoneValue == ZoneValue.NotOnOff && isOnOff)
					{
						isMatch = false;
						break;
					}
				}

				if (isMatch)
					return charDef.Character[0];
			}

			return '\0';
	    }


	    public char RecognizeChar(double[] computedZones, int median, int charPosition)
        {
            int MAX_OFF_VALUE_FOR_MEDIAN = median + (MIN_ON_VALUE - median) / 4;

            foreach (CharDefinition charDef in charDefinitions)
            {
                if (charDef.FixedPosition != null &&
                    charDef.FixedPosition.Value != charPosition)
                {
                    continue;
                }

                bool isMatch = true;

                foreach(ZoneSignature zoneSign in charDef.ZoneSignatures)
                {
                    if (zoneSign.ZoneValue == ZoneValue.On && computedZones[zoneSign.ZoneId] < MIN_ON_VALUE)
                    {
                        isMatch = false;
                        break;
                    }

					if (zoneSign.ZoneValue == ZoneValue.Off && computedZones[zoneSign.ZoneId] >= MAX_OFF_VALUE_FOR_MEDIAN)
                    {
                        isMatch = false;
                        break;                        
                    }

					if (zoneSign.ZoneValue == ZoneValue.Gray && (computedZones[zoneSign.ZoneId] < MAX_OFF_VALUE_FOR_MEDIAN || computedZones[zoneSign.ZoneId] > MIN_ON_VALUE))
                    {
                        isMatch = false;
                        break;
                    }

                    if (zoneSign.ZoneValue == ZoneValue.NotOn && computedZones[zoneSign.ZoneId] > MIN_ON_VALUE)
                    {
                        isMatch = false;
                        break;
                    }

					if (zoneSign.ZoneValue == ZoneValue.NotOff && computedZones[zoneSign.ZoneId] < MAX_OFF_VALUE_FOR_MEDIAN)
                    {
                        isMatch = false;
                        break;
                    }
                }   

                if (isMatch)
                    return charDef.Character[0];
            }

            return '\0';
        }
    }
}
