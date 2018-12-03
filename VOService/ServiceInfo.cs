using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class ServiceInfo
    {
        static long serialVersionUID = 1;

        private ServiceVO[] services;

        public ServiceVO[] Services
        {
            get { return services; }
            set { services = value; }
        }
        private String sMachineName;

        public String SMachineName
        {
            get { return sMachineName; }
            set { sMachineName = value; }
        }
        private String iMachineId;

        public String IMachineId
        {
            get { return iMachineId; }
            set { iMachineId = value; }
        }
        private String sDataDownloadDirectory;

        public String SDataDownloadDirectory
        {
            get { return sDataDownloadDirectory; }
            set { sDataDownloadDirectory = value; }
        }
        private String sDataUploadDirectory;

        public String SDataUploadDirectory
        {
            get { return sDataUploadDirectory; }
            set { sDataUploadDirectory = value; }
        }
        private int iUploadFrequency;

        public int IUploadFrequency
        {
            get { return iUploadFrequency; }
            set { iUploadFrequency = value; }
        }
        private Boolean bIsProxyServerUsed;

        public Boolean BIsProxyServerUsed
        {
            get { return bIsProxyServerUsed; }
            set { bIsProxyServerUsed = value; }
        }
        private String sProxyHost;

        public String SProxyHost
        {
            get { return sProxyHost; }
            set { sProxyHost = value; }
        }
        private string sProxyPort;

        public string SProxyPort
        {
            get { return sProxyPort; }
            set { sProxyPort = value; }
        }
        private String sProxyUser;

        public String SProxyUser
        {
            get { return sProxyUser; }
            set { sProxyUser = value; }
        }
        private String sProxyPassword;

        public String SProxyPassword
        {
            get { return sProxyPassword; }
            set { sProxyPassword = value; }
        }

        public string sCommunicatorServicePortForDLD { get; set; }


        public string sCommunicatorServicePortForBrowserAndAuth { get; set; }

        private String sAuthenticationServicePortForCommunicatorService;

        public String SAuthenticationServicePortForCommunicatorService
        {
            get { return sAuthenticationServicePortForCommunicatorService; }
            set { sAuthenticationServicePortForCommunicatorService = value; }
        }
        private String sAuthenticationServicePortForBrowser;

        public String SAuthenticationServicePortForBrowser
        {
            get { return sAuthenticationServicePortForBrowser; }
            set { sAuthenticationServicePortForBrowser = value; }
        }

        private String sRDSPort;
        public String SRDSPort
        {
            get { return sRDSPort; }
            set { sRDSPort = value; }
        }

        private String sRDSHost;
        public String SRDSHost
        {
            get { return sRDSHost; }
            set { sRDSHost = value; }
        }
    }

    // CR 446 Change For Automatic Service Restart
    public class ServiceResetInfo
    {
        public int ServiceId { get; set; }
        public int ServiceTypeId { get; set; }
        public bool ResetFlag { get; set; }
        public int RestartTimer { get; set; } 
    }

    public class BackgroundServiceSetting
    {
        private bool authFlag=false;
        public bool FetchAuthLogs
        {
            get { return authFlag; }
            set { authFlag=value; }
        }
        public double? RequestStart { get; set; }
        public double? RequestEnd { get; set; }

    }
}
