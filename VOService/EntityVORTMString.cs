using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class EntityVORTMString
    {
        static long serialVersionUID = 1;
        private String entityId;

        public String EntityId
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
        private String entityName;

        public String EntityName
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
    }
}
