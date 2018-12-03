using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class DLDPatchVO
    {
        private String dESN = "";

        public String DESN
        {
            get { return dESN; }
            set { dESN = value; }
        }
        private String sTAT = "";

        public String STAT
        {
            get { return sTAT; }
            set { sTAT = value; }
        }
        private String sWVS = "";

        public String SWVS
        {
            get { return sWVS; }
            set { sWVS = value; }
        }
        private String dADT = "";

        public String DADT
        {
            get { return dADT; }
            set { dADT = value; }
        }
        private String dHCP = "";

        public String DHCP
        {
            get { return dHCP; }
            set { dHCP = value; }
        }
        private String sUBN = "";

        public String SUBN
        {
            get { return sUBN; }
            set { sUBN = value; }
        }
        private String dNS1 = "";

        public String DNS1
        {
            get { return dNS1; }
            set { dNS1 = value; }
        }
        private String gTWY = "";

        public String GTWY
        {
            get { return gTWY; }
            set { gTWY = value; }
        }
        private String dNS2 = "";

        public String DNS2
        {
            get { return dNS2; }
            set { dNS2 = value; }
        }
        private String wLIP = "";

        public String WLIP
        {
            get { return wLIP; }
            set { wLIP = value; }
        }
        private String sSID = "";

        public String SSID
        {
            get { return sSID; }
            set { sSID = value; }
        }
        private String iNTP = "";

        public String INTP
        {
            get { return iNTP; }
            set { iNTP = value; }
        }
        private String wRTE = "";

        public String WRTE
        {
            get { return wRTE; }
            set { wRTE = value; }
        }
        private String sECR = "";

        public String SECR
        {
            get { return sECR; }
            set { sECR = value; }
        }
        private String cYPL = "";

        public String CYPL
        {
            get { return cYPL; }
            set { cYPL = value; }
        }
        private String tCPP = "";

        public String TCPP
        {
            get { return tCPP; }
            set { tCPP = value; }
        }
        private String wPPP = "";

        public String WPPP
        {
            get { return wPPP; }
            set { wPPP = value; }
        }
        private String wPPF = "";

        public String WPPF
        {
            get { return wPPF; }
            set { wPPF = value; }
        }
        private String sAD1 = "";

        public String SAD1
        {
            get { return sAD1; }
            set { sAD1 = value; }
        }
        private String sDNS = "";

        public String SDNS
        {
            get { return sDNS; }
            set { sDNS = value; }
        }
        private String dNSH = "";

        public String DNSH
        {
            get { return dNSH; }
            set { dNSH = value; }
        }
        private String commServerIndicator = "";

        public String CommServerIndicator
        {
            get { return commServerIndicator; }
            set { commServerIndicator = value; }
        }
        public string RDC1 { get; set; }//ReadOnly CAN1 
        public string RDC2 { get; set; }//ReadOnly CAN2
        public string SRI1 { get; set; }//Serial Interface 1
        public string SRI2 { get; set; }//Serial Interface 2
        public string ENCY { get; set; }//Encryption
        public WLANSettingVO[] wlanSetting;


        private String performAT = "";
        public string PERFORM_AT
        {
            get { return performAT; }
            set { performAT = value; }
        }

        private String timeWifi = "";

        public string TIME_WiFi
        {
            get { return timeWifi; }
            set { timeWifi = value; }
        }


        private String timeGSM = "";
        public string TIME_GSM
        {
            get { return timeGSM; }
            set { timeGSM = value; }
        }

        public string TIME_ROAMING { get; set; }

        private String timerRetry = "";
        public string TIMER_RETRY
        {
            get { return timerRetry; }
            set { timerRetry = value; }
        }


        private String nretries = "";
        public string NRETRIES
        {
            get { return nretries; }
            set { nretries = value; }
        }

        //new Properties for Profile Details
        public string DATA_SOURCE { get; set; }
        public string MESSAGE { get; set; }
        public string PGN1 { get; set; }
        public string DATA_TYPE { get; set; }
        public string DATA_CHANGED { get; set; }
        public string TRIGGER_DATA { get; set; }
        public string PGN2 { get; set; }
        public string TRIGGER_FILTER { get; set; }
        public string TIME_IGNITION_ON { get; set; }
        public string TIME_IGNITION_OFF { get; set; }
        public string RECORD_DISTANCE { get; set; }

        // 1b1 Change R-64
        public string PROFILEID { get; set; }
    }
}
