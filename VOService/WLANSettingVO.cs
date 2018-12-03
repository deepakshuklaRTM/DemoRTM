using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class WLANSettingVO
    {
        public string CYPL { get; set; }//iCipherLength
        public string DNS1 { get; set; }//sDNS1
        public string GTWY { get; set; }//sGateWay
        public string DHCP { get; set; }//bIsDHCPOff
        public string INTP { get; set; }//iWLANInterfaceTypeID
        public string WRTE { get; set; }//iWLANRateId
        public string SECR { get; set; }//iWLANSecurityID
        public string SSID { get; set; }//sSSID
        public string WPPP { get; set; }//sPhrase
        public string WPPF { get; set; }//iPhraseFormatID
        public string DNS2 { get; set; }//sDNS2
        public string SUBN { get; set; }//sSubnet
        public string TCPP { get; set; }//sRTMPortForDLD
        public string SAD1 { get; set; }//sMachineIP
        public string SDNS { get; set; }
        public string DNSH { get; set; }
        public string WLIP { get; set; }//sIPDHCPOff 
    }
}
