using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VOService
{
    public class DTCOVO
    {
        static long serialVersionUID = 1;

        public static int DTCOConsts = 4;



        private byte[] vehicleRegistrationNumber;

        public byte[] VehicleRegistrationNumber
        {
            get { return vehicleRegistrationNumber; }
            set { vehicleRegistrationNumber = value; }
        }

        private String remoteDeviceSerialNumber;

        public String RemoteDeviceSerialNumber
        {
            get { return remoteDeviceSerialNumber; }
            set { remoteDeviceSerialNumber = value; }
        }



        private int activityFromDate;

        public int ActivityFromDate
        {
            get { return activityFromDate; }
            set { activityFromDate = value; }
        }

        private int activityToDate;

        public int ActivityToDate
        {
            get { return activityToDate; }
            set { activityToDate = value; }
        }

        private int commtype;

        public int Commtype
        {
            get { return commtype; }
            set { commtype = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int retryCount;

        public int RetryCount
        {
            get { return retryCount; }
            set { retryCount = value; }
        }



        private byte[] entityId;

        public byte[] EntityId
        {
            get { return entityId; }
            set { entityId = value; }
        }




        private int dldType;

        public int DldType
        {
            get { return dldType; }
            set { dldType = value; }
        }


        private byte failureCode;

        public byte FailureCode
        {
            get { return failureCode; }
            set { failureCode = value; }
        }

        private int timeStamp;

        public int TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        private int timeStampAuthenticationStarted;

        public int TimeStampAuthenticationStarted
        {
            get { return timeStampAuthenticationStarted; }
            set { timeStampAuthenticationStarted = value; }
        }
        private int companyID;

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        private int remoteServiceID;

        public int RemoteServiceID
        {
            get { return remoteServiceID; }
            set { remoteServiceID = value; }
        }

        private List<byte[]> arReminderList;

        public List<byte[]> ArReminderList
        {
            get { return arReminderList; }
            set { arReminderList = value; }
        }
        private int authType;

        public int AuthType
        {
            get { return authType; }
            set { authType = value; }
        }
        private String strDTCOVersion = "";

        public String StrDTCOVersion
        {
            get { return strDTCOVersion; }
            set { strDTCOVersion = value; }
        }

        private int ispecialFromDate;

        public int specialFromDate
        {
            get { return ispecialFromDate; }
            set { ispecialFromDate = value; }
        }

        private int ispecialToDate;

        public int specialToDate
        {
            get { return ispecialToDate; }
            set { ispecialToDate = value; }
        }

        // AT Ticket 125

        private byte[] machineID;
        public byte[] MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }
         


    }
}
