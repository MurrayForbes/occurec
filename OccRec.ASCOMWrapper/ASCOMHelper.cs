﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OccuRec.ASCOM.Interfaces;
using OccuRec.ASCOM.Interfaces.Devices;

namespace OccRec.ASCOMWrapper
{
	[Serializable]
    internal class ASCOMHelper : DeviceClient, IASCOMHelper
	{
		private IASCOMHelper m_IsolatedHelper;
		public ASCOMHelper(ASCOMClient client)
		{
			LoadInAppDomain("OccuRec.ASCOM.Server.ASCOMHelper, OccuRec.ASCOM.Server", client);
			m_IsolatedHelper = m_Instance as IASCOMHelper;
		}

		public string ChooseFocuser()
		{
			return m_IsolatedHelper.ChooseFocuser();
		}

		public string ChooseTelescope()
		{
			return m_IsolatedHelper.ChooseTelescope();
		}

		public IASCOMFocuser CreateFocuser(string progId)
		{
			return m_IsolatedHelper.CreateFocuser(progId);
		}

        public IASCOMTelescope CreateTelescope(string progId)
        {
            return m_IsolatedHelper.CreateTelescope(progId);
        }
	}
}
