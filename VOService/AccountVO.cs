using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOService
{
    public class AccountVO
    {
        private int accountId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private String accountName;

        public String AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private int deviceType;

        public int DeviceType
        {
            get { return deviceType; }
            set { deviceType = value; }
        }
        private int archiveMode;

        public int ArchiveMode
        {
            get { return archiveMode; }
            set { archiveMode = value; }
        }
        private String urlTW;

        public String UrlTW
        {
            get { return urlTW; }
            set { urlTW = value; }
        }
        private string sTISOfficeServer;

        public string STISOfficeServer
        {
            get { return sTISOfficeServer; }
            set { sTISOfficeServer = value; }
        }
        private Boolean bSVSpecificDataIndicator;

        public Boolean BSVSpecificDataIndicator
        {
            get { return bSVSpecificDataIndicator; }
            set { bSVSpecificDataIndicator = value; }
        }
        private Boolean modifiedRL;

        public Boolean ModifiedRL
        {
            get { return modifiedRL; }
            set { modifiedRL = value; }
        }
        private EntityVORTM[] manualEntities;

        public EntityVORTM[] ManualEntities
        {
            get { return manualEntities; }
            set { manualEntities = value; }
        }

        private List<EntityVORTM> automaticEntities;

        public List<EntityVORTM> AutomaticEntities
        {
            get { return automaticEntities; }
            set { automaticEntities = value; }
        }
        private string sTISOfficeCompany;

        public string STISOfficeCompany
        {
            get { return sTISOfficeCompany; }
            set { sTISOfficeCompany = value; }
        }
        private Boolean bManualTaskExist;

        public Boolean BManualTaskExist
        {
            get { return bManualTaskExist; }
            set { bManualTaskExist = value; }
        }
        private Boolean bIsActivityDataBlock;

        public Boolean BIsActivityDataBlock
        {
            get { return bIsActivityDataBlock; }
            set { bIsActivityDataBlock = value; }
        }
        private Boolean bIsEventandFaultsDataBlock;

        public Boolean BIsEventandFaultsDataBlock
        {
            get { return bIsEventandFaultsDataBlock; }
            set { bIsEventandFaultsDataBlock = value; }
        }
        private Boolean bIsDetailedSpeedblock;

        public Boolean BIsDetailedSpeedblock
        {
            get { return bIsDetailedSpeedblock; }
            set { bIsDetailedSpeedblock = value; }
        }
        private Boolean bIsTechnicalDataBlock;

        public Boolean BIsTechnicalDataBlock
        {
            get { return bIsTechnicalDataBlock; }
            set { bIsTechnicalDataBlock = value; }
        }
        private Boolean bIsDCFilesDownloadWithVUFile;

        public Boolean BIsDCFilesDownloadWithVUFile
        {
            get { return bIsDCFilesDownloadWithVUFile; }
            set { bIsDCFilesDownloadWithVUFile = value; }
        }
        private Boolean bIs168HrsDetailedSpeedDataBlock;

        public Boolean BIs168HrsDetailedSpeedDataBlock
        {
            get { return bIs168HrsDetailedSpeedDataBlock; }
            set { bIs168HrsDetailedSpeedDataBlock = value; }
        }
        private Boolean bIsMulipurposeDataBlock;

        public Boolean BIsMulipurposeDataBlock
        {
            get { return bIsMulipurposeDataBlock; }
            set { bIsMulipurposeDataBlock = value; }
        }
        private string iDCFileExtensionID;

        public string IDCFileExtensionID
        {
            get { return iDCFileExtensionID; }
            set { iDCFileExtensionID = value; }
        }
        private string iVUFileExtensionID;

        public string IVUFileExtensionID
        {
            get { return iVUFileExtensionID; }
            set { iVUFileExtensionID = value; }
        }
        private string iVDOFileExtensionID;

        public string IVDOFileExtensionID
        {
            get { return iVDOFileExtensionID; }
            set { iVDOFileExtensionID = value; }
        }
        private Boolean bIsFlagReset;
        public Boolean BIsFlagReset
        {
            get { return bIsFlagReset; }
            set { bIsFlagReset = value; }
        }

        private DueDownloadVORTM dueDownloadVORTM;
        public DueDownloadVORTM DueDownloadRVOTM
        {
            get { return dueDownloadVORTM; }
            set { dueDownloadVORTM = value; }
        }

        private List<EntityVORTM> deleteEntities;
        public List<EntityVORTM> DeleteEntities
        {
            get { return deleteEntities; }
            set { deleteEntities = value; }
        }

        private Boolean blsSmartLinkAvailable;
        public Boolean BlsSmartLinkAvailable
        {
            get { return blsSmartLinkAvailable; }
            set { blsSmartLinkAvailable = value; }
        }

    }
}