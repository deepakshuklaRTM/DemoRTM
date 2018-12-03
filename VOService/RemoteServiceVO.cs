using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class RemoteServiceVO
    {
        static long serialVersionUID = 1;
        private string accountNameRS;

        public string AccountNameRS
        {
            get { return accountNameRS; }
            set { accountNameRS = value; }
        }
        private string userNameRS;

        public string UserNameRS
        {
            get { return userNameRS; }
            set { userNameRS = value; }
        }
        private string passwordRS;

        public string PasswordRS
        {
            get { return passwordRS; }
            set { passwordRS = value; }
        }
        private string urlRS;

        public string UrlRS
        {
            get { return urlRS; }
            set { urlRS = value; }
        }
        private int dldType;

        public int DldType
        {
            get { return dldType; }
            set { dldType = value; }
        }
        private int companyID;

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        private Boolean proxyRequired;

        public Boolean ProxyRequired
        {
            get { return proxyRequired; }
            set { proxyRequired = value; }
        }
        private string proxyHost;

        public string ProxyHost
        {
            get { return proxyHost; }
            set { proxyHost = value; }
        }
        private string proxyPort;

        public string ProxyPort
        {
            get { return proxyPort; }
            set { proxyPort = value; }
        }
        private string proxyUser;

        public string ProxyUser
        {
            get { return proxyUser; }
            set { proxyUser = value; }
        }
        private string proxyPassword;

        public string ProxyPassword
        {
            get { return proxyPassword; }
            set { proxyPassword = value; }
        }
        public int remoteServiceId { get; set; }

    }
}
