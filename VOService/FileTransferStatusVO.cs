using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class FileTransferStatusVO
    {

        private static long serialVersionUID = 1L;
        private byte statusCode = 0;

        public byte StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        private String cmdName = "";

        public String CmdName
        {
            get { return cmdName; }
            set { cmdName = value; }
        }
        private String serialId = "";

        public String SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }
        private byte[] entityName;

        public byte[] EntityName
        {
            get { return entityName; }
            set { entityName = value; }
        }
        private byte[] entityId;

        public byte[] EntityId
        {
            get { return entityId; }
            set { entityId = value; }
        }
        private byte[] fileName;

        public byte[] FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private String failureCode = "";

        public String FailureCode
        {
            get { return failureCode; }
            set { failureCode = value; }
        }
        private byte errorCode;

        public byte ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }
        private String uploadRetryCount = "";

        public String UploadRetryCount
        {
            get { return uploadRetryCount; }
            set { uploadRetryCount = value; }
        }
        private int authType;

        public int AuthType
        {
            get { return authType; }
            set { authType = value; }
        }
        private int dldType;

        public int DldType
        {
            get { return dldType; }
            set { dldType = value; }
        }
        private byte previousStatus = 0;

        public byte PreviousStatus
        {
            get { return previousStatus; }
            set { previousStatus = value; }
        }
        private String initTimeStamp;

        public String InitTimeStamp
        {
            get { return initTimeStamp; }
            set { initTimeStamp = value; }
        }
        private int companyID;

        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }
        private int updatedStatus;

        public int UpdatedStatus
        {
            get { return updatedStatus; }
            set { updatedStatus = value; }
        }
        private int remoteServiceID;

        public int RemoteServiceID
        {
            get { return remoteServiceID; }
            set { remoteServiceID = value; }
        }
        private int reminderID;

        public int ReminderID
        {
            get { return reminderID; }
            set { reminderID = value; }
        }

        /// <summary>
        /// New Property for File uploaded on server
        /// </summary>
        public bool IsFileAvailable { get; set; }
    }
}
