using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOService
{
    public class CommandStatusVO:DataBlock
    {
        public static byte OPEN = 0;
        public static byte SENT = 1;
        public static byte FAILED = 2;
        public static byte RECEIVED = 3;
        public byte UPLOADED = 4;
        public static byte NO_DATA_AVAILABLE = 5;
        public static byte RECEIVE_FAILED = 6;
        public byte UPLOAD_FAILED = 7;

        public static byte FAILURECODE_OK = 0;
        public static byte FAILURECODE_GEN = 1;
        public static byte FAILURECODE_WEBSERVICE_NOT_WORKING = 2;
        public static byte FAILURECODE_INVALID_ACCOUNT = 3;
        public static byte FAILURECODE_INVALID_USER_PWD = 4;
        public static byte FAILURECODE_DOWNLOAD_INTERRUPTED = 5;
        public static byte FAILURECODE_INVALID_DATAFILE = 6;
        public static byte FAILURECODE_MANDATORY_DATABLOCK_MISSING = 7;
        public static byte FAILURECODE_UNABLE_TO_STORE_FILE = 8;
        public static byte FAILURECODE_DLD_BUSY = 6;
        /*
         * Rajesh H.
         * RTM AT-2 TM0000436 Task
         */
        public static byte FAILURECODE_GRACE_PERIOD = 11;

        private String cmdSeqId;

        public String CmdSeqId
        {
            get { return cmdSeqId; }
            set { cmdSeqId = value; }
        }
        private byte statusCode = OPEN;

        public byte StatusCode
        {
            get { return statusCode; }
            set { statusCode = value; }
        }
        private String cmdName;

        public String CmdName
        {
            get { return cmdName; }
            set { cmdName = value; }
        }
        private String serialId;

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
        private String initTimeStamp;

        public String InitTimeStamp
        {
            get { return initTimeStamp; }
            set { initTimeStamp = value; }
        }
        private String isFinal = "N";

        public String IsFinal
        {
            get { return isFinal; }
            set { isFinal = value; }
        }
        private String failureCode;

        public String FailureCode
        {
            get { return failureCode; }
            set { failureCode = value; }
        }
        private String shouldMove = "N";

        public String ShouldMove
        {
            get { return shouldMove; }
            set { shouldMove = value; }
        }
        private byte errorCode = FAILURECODE_OK;

        public byte ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        private String patchVersion;

        public String PatchVersion
        {
            get { return patchVersion; }
            set { patchVersion = value; }
        }

        public string CurrentinitTimeStamp { get; set; }

        /// <summary>
        /// New property for intit to date Ticket: TM0000989 
        /// </summary>
        /// 

        private String initTimeStamp_ToDate;

        public String InitTimeStamp_ToDate
        {
            get { return initTimeStamp_ToDate; }
            set { initTimeStamp_ToDate = value; }
        }

        public int iRemonderID { get; set; }
        public int iVDOReminderID { get; set; }
        public int iDLDErrorTypeId { get; set; }
        public string sDLDDiagnosticFilename { get; set; }

        /// <summary>
        /// New Property for File uploaded on server
        /// </summary>
        public bool IsFileAvailable { get; set; }

        /// <summary>
        /// R-138 Changes.  Traceability code for R-138 :  CR467.1001.001
        /// </summary>
        public string EntityType { get; set; }
        public string CardNo { get; set; }
        public string MemberStateCode { get; set; }
    }

    public class DataBlock
    {
        public bool bIsOverviewDataBlock { get; set; }
        public bool bIsActivityDataBlock { get; set; }
        public bool bIsEventandFaultsDataBlock { get; set; }
        public bool bIsDetailedSpeedblock { get; set; }
        public bool bIsTechnicalDataBlock { get; set; }
    }

    //CR-457 Implementation Traceability code: CR457.1002.006
    public class CommandRequestVO
    {
        public string version { get; set; }
        public string cmdName { get; set; }
        public CommandDSUGData CommandDSUGData { get; set; }
    }

    //CR-457 Implementation Traceability code: CR457.1002.006
    public class CommandDSUGData
    {
        public List<string> serialId { get; set; }
        public List<string> patchFileName { get; set; }
        public int startIndex { get; set; }
        public int lastIndex { get; set; }
        public List<string> patchVersion { get; set; }
    }
    //CR-457 Implementation Traceability code: CR457.1002.006
    public class DLDUpgrade
    {
        public string serialId { get; set; }
        public string patchFileName { get; set; }
    }
}