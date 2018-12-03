using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class SmartLinkConfigurationVO
    {
        public string strSerialId { get; set; }
        public string strSmartPhoneIMEI { get; set; }
        public string strBaseFirmwareVersionDesc { get; set; }
        public string strFirmwareVersionDesc { get; set; }
        public string strTISFleetAppVersion { get; set; }
        public string strWLANMacAddress { get; set; }
        public string strBlueToothAddress { get; set; }
        public string strAndroidVersion { get; set; }
        public string strSmartPhoneManufacturer { get; set; }
    }
}
