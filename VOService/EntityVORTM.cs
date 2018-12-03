using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOService
{
    public class EntityVORTM
    {
        static long serialVersionUID = 1;
        private byte[] entityId;

        public byte[] EntityId
        {
            get { return entityId; }
            set { entityId = value; }
        }
        private String entityNumber;

        public String EntityNumber
        {
            get { return entityNumber; }
            set { entityNumber = value; }
        }
        private byte[] entityName;

        public byte[] EntityName
        {
            get { return entityName; }
            set { entityName = value; }
        }
        private String fromDate;

        public String FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private String toDate;

        public String ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        private String recurrence;

        public String Recurrence
        {
            get { return recurrence; }
            set { recurrence = value; }
        }
        private String nextDownloadDate;

        public String NextDownloadDate
        {
            get { return nextDownloadDate; }
            set { nextDownloadDate = value; }
        }
        private String requestDataBlock;

        public String RequestDataBlock
        {
            get { return requestDataBlock; }
            set { requestDataBlock = value; }
        }
        private String lastDownloadDate;

        public String LastDownloadDate
        {
            get { return lastDownloadDate; }
            set { lastDownloadDate = value; }
        }
        private String companyName;

        public String CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private String ext;

        public String Ext
        {
            get { return ext; }
            set { ext = value; }
        }
        private String companyId;

        public String CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        private String deviceType;

        public String DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }
        private String reminderID;

        public String ReminderID
        {
            get { return reminderID; }
            set { reminderID = value; }
        }
        public int iSiteID { get; set; }

        private int iReminderID;

        public int IReminderID
        {
            get { return iReminderID; }
            set { iReminderID = value; }
        }

        private String sFleetAppVersion;

        public String SFleetAppVersion
        {
            get { return sFleetAppVersion; }
            set { sFleetAppVersion = value; }
        }

        private String sFleetAppOSName;

        public String SFleetAppOSName
        {
            get { return sFleetAppOSName ; }
            set { sFleetAppOSName  = value; }
        }

        private String sFleetAppOSVersion;

        public String SFleetAppOSVersion
        {
            get { return sFleetAppOSVersion; }
            set { sFleetAppOSVersion = value; }
        }

        private String sFleetAppUserName;

        public String SFleetAppUserName
        {
            get { return sFleetAppUserName; }
            set { sFleetAppUserName = value; }
        }

        private String sFleetAppPassword;

        public String SFleetAppPassword
        {
            get { return sFleetAppPassword; }
            set { sFleetAppPassword = value; }
        }

        private Boolean bAllowToUseFleetApp;
        public Boolean BAllowToUseFleetApp
        {
            get { return bAllowToUseFleetApp; }
            set { bAllowToUseFleetApp = value; }
        }

        private Boolean bDownloadMassMemory;
        public Boolean BDownloadMassMemory
        {
            get { return bDownloadMassMemory; }
            set { bDownloadMassMemory = value; }
        }

        private Boolean bMessaging;
        public Boolean BMessaging
        {
            get { return bMessaging; }
            set { bMessaging = value; }
        }

        private Boolean bVehicleCheck;
        public Boolean BVehicleCheck
        {
            get { return bVehicleCheck; }
            set { bVehicleCheck = value; }
        }

        private Boolean bDownloadDrvCard;
        public Boolean BDownloadDrvCard
        {
            get { return bDownloadDrvCard; }
            set { bDownloadDrvCard = value; }
        } 

        private Boolean bReminder;
        public Boolean BReminder
        {
            get { return bReminder; }
            set { bReminder = value; }
        }

        private DateTime? dOnlineStatus;
        public DateTime? DOnlineStatus
        {
            get { return dOnlineStatus; }
            set { dOnlineStatus = value; }
        }

        private int iTISWebDriverId;
        public int ITISWebDriverId
        {
            get { return iTISWebDriverId; }
            set { iTISWebDriverId = value; }
        }

        private string sPreferedLanguage;
        public string SPreferedLanguage
        {
            get { return sPreferedLanguage; }
            set { sPreferedLanguage = value; }
        } 
    }
}