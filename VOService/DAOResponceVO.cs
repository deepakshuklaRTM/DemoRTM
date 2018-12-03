using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class DAOResponceVO
    {
        private int iCompanyID = 0;

        public int ICompanyID
        {
            get { return iCompanyID; }
            set { iCompanyID = value; }
        }
        private int commType = 0;

        public int CommType
        {
            get { return commType; }
            set { commType = value; }
        }
        private Boolean bSVSpecificDataIndicator = false;

        public Boolean BSVSpecificDataIndicator
        {
            get { return bSVSpecificDataIndicator; }
            set { bSVSpecificDataIndicator = value; }
        }
        private int iArchiveMode = 0;

        public int IArchiveMode
        {
            get { return iArchiveMode; }
            set { iArchiveMode = value; }
        }
        private String companyName;

        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        //getCompanyID

        //checkEntityReminderList
        private String massMemoryType = "-1";

        public String MassMemoryType
        {
            get { return massMemoryType; }
            set { massMemoryType = value; }
        }
        private String specialDataType = "-1";

        public String SpecialDataType
        {
            get { return specialDataType; }
            set { specialDataType = value; }
        }
        private String coDriverType = "-1";

        public String CoDriverType
        {
            get { return coDriverType; }
            set { coDriverType = value; }
        }
        private String driverType = "-1";

        public String DriverType
        {
            get { return driverType; }
            set { driverType = value; }
        }
        //checkEntityReminderList

        //getListOfTISWebURLs
        private String uRL = "";

        public String URL
        {
            get { return uRL; }
            set { uRL = value; }
        }
        private String accountIdTW = "";

        public String AccountIdTW
        {
            get { return accountIdTW; }
            set { accountIdTW = value; }
        }
        private String userNameTW = "";

        public String UserNameTW
        {
            get { return userNameTW; }
            set { userNameTW = value; }
        }
        private String passwordTW = "";

        public String PasswordTW
        {
            get { return passwordTW; }
            set { passwordTW = value; }
        }
        private String proxyRequired = "";

        public String ProxyRequired
        {
            get { return proxyRequired; }
            set { proxyRequired = value; }
        }
        private String proxyHost = "";

        public String ProxyHost
        {
            get { return proxyHost; }
            set { proxyHost = value; }
        }
        private String proxyPort = "";

        public String ProxyPort
        {
            get { return proxyPort; }
            set { proxyPort = value; }
        }
        //getListOfTISWebURLs

        //getListOfRSURLs
        private int remoteServiceID = 0;

        public int RemoteServiceID
        {
            get { return remoteServiceID; }
            set { remoteServiceID = value; }
        }
        private String accountIDRS = "";

        public String AccountIDRS
        {
            get { return accountIDRS; }
            set { accountIDRS = value; }
        }
        private String userName = "";

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password = "";

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private String proxyIP = "";

        public String ProxyIP
        {
            get { return proxyIP; }
            set { proxyIP = value; }
        }
        private String proxyUser = "";

        public String ProxyUser
        {
            get { return proxyUser; }
            set { proxyUser = value; }
        }
        private String proxyPassword = "";

        public String ProxyPassword
        {
            get { return proxyPassword; }
            set { proxyPassword = value; }
        }

        private int reminderIDVU;

        public int ReminderIDVU
        {
            get { return reminderIDVU; }
            set { reminderIDVU = value; }
        }
        private int reminderIDSV;

        public int ReminderIDSV
        {
            get { return reminderIDSV; }
            set { reminderIDSV = value; }
        }
        private int reminderIDDriver;

        public int ReminderIDDriver
        {
            get { return reminderIDDriver; }
            set { reminderIDDriver = value; }
        }
        private int reminderIDCoDriver;

        public int ReminderIDCoDriver
        {
            get { return reminderIDCoDriver; }
            set { reminderIDCoDriver = value; }
        }
    }
}
