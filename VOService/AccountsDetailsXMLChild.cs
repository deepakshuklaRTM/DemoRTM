using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
   public class AccountsDetailsXMLChild
    {
       static  long serialVersionUID=1;
       private int accountId;

       public int AccountId
       {
           get { return accountId; }
           set { accountId = value; }
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
       private String sTISOfficeServer;

       public String STISOfficeServer
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
       private String sTISOfficeCompany;

       public String STISOfficeCompany
       {
           get { return sTISOfficeCompany; }
           set { sTISOfficeCompany = value; }
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
       /// Date : 15-09-2016
       /// Handling CSVS Command (Background Service) in CTL in case of WR DLD2***********************************/
       private Boolean bIsSmartLinkAvailable;

       public Boolean BIsSmartLinkAvailable
       {
           get { return bIsSmartLinkAvailable; }
           set { bIsSmartLinkAvailable = value; }
       }
       private Boolean bIsDLDWRIIAvailable;

       public Boolean BIsDLDWRIIAvailable
       {
           get { return bIsDLDWRIIAvailable; }
           set { bIsDLDWRIIAvailable = value; }
       }
        /**************************************/
    }
}
