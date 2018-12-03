using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOService
{
    public class RemoteDeviceRegistrationVO
    {
        private static long serialVersionUID = 1L;

        public static long SerialVersionUID
        {
            get { return RemoteDeviceRegistrationVO.serialVersionUID; }
            set { RemoteDeviceRegistrationVO.serialVersionUID = value; }
        }

        private byte[] driverCardNo;

        public byte[] DriverCardNo
        {
            get { return driverCardNo; }
            set { driverCardNo = value; }
        }
        private String serialId;

        public String SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }
        private byte[] vin;

        public byte[] Vin
        {
            get { return vin; }
            set { vin = value; }
        }
        private byte[] vrn;

        public byte[] Vrn
        {
            get { return vrn; }
            set { vrn = value; }
        }
        private byte[] coDriverCardNo;

        public byte[] CoDriverCardNo
        {
            get { return coDriverCardNo; }
            set { coDriverCardNo = value; }
        }
        private String isClientIntimatedVeh = "N";

        public String IsClientIntimatedVeh
        {
            get { return isClientIntimatedVeh; }
            set { isClientIntimatedVeh = value; }
        }
        private String isClientIntimatedDrv = "N";

        public String IsClientIntimatedDrv
        {
            get { return isClientIntimatedDrv; }
            set { isClientIntimatedDrv = value; }
        }
        private String isClientIntimatedCoDrv = "N";

        public String IsClientIntimatedCoDrv
        {
            get { return isClientIntimatedCoDrv; }
            set { isClientIntimatedCoDrv = value; }
        }
        private byte[] vrnConnected; // TIS-Support Ticket TM0000376: Modified name

        public byte[] VrnConnected
        {
            get { return vrnConnected; }
            set { vrnConnected = value; }
        }
        private Boolean registrationCommand = true;

        public Boolean RegistrationCommand
        {
            get { return registrationCommand; }
            set { registrationCommand = value; }
        }
        private Boolean newDLD = true;

        public Boolean NewDLD
        {
            get { return newDLD; }
            set { newDLD = value; }
        }
        private String accountName;

        public String AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }


        private int accountId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }


        private String archiveMode;

        public String ArchiveMode
        {
            get { return archiveMode; }
            set { archiveMode = value; }
        }
        private Boolean vehicleConnected = false; // TIS-Support Ticket TM0000376: Added

        public Boolean VehicleConnected
        {
            get { return vehicleConnected; }
            set { vehicleConnected = value; }
        }
        private String version;

        public String Version
        {
            get { return version; }
            set { version = value; }
        }
        private String manufacturerCode; // CR302

        public String ManufacturerCode
        {
            get { return manufacturerCode; }
            set { manufacturerCode = value; }
        }
        //Add for WBS 4.2.2
        private String commMode;

        public String CommMode
        {
            get { return commMode; }
            set { commMode = value; }
        }
        private String hardWareVersion;

        public String HardWareVersion
        {
            get { return hardWareVersion; }
            set { hardWareVersion = value; }
        }
        private String tcoFile;

        public String TcoFile
        {
            get { return tcoFile; }
            set { tcoFile = value; }
        }
        private String emotachData;

        public String EmotachData
        {
            get { return emotachData; }
            set { emotachData = value; }
        }
        private String gpsData;

        public String GpsData
        {
            get { return gpsData; }
            set { gpsData = value; }
        }
        public string configUpdate { get; set; }
        public string swUpgradeResult { get; set; }

        public Boolean vrnFlag { get; set; }
        public Boolean driverCardFlag { get; set; }
        public Boolean coDriverCardFlag { get; set; }

        private String sEmotachDeviceName;

        public String SEmotachDeviceName
        {
            get { return sEmotachDeviceName; }
            set { sEmotachDeviceName = value; }
        }

        private String sSerialNo;

        public String SSerialNo
        {
            get { return sSerialNo; }
            set { sSerialNo = value; }
        }

        private int iDeviceType;

        public int IDeviceType
        {
            get { return iDeviceType; }
            set { iDeviceType = value; }
        }

        public Boolean bDetailDebuging { get; set; }
        public string assetType { get; set; }

        // Change For CTL Issue
        public string EntityId { get; set; }

        private bool _entityPresent = false;

        public bool EntityPresent
        {
            get { return _entityPresent; }
            set { _entityPresent = value; }
        }

        //CR 467 R-129 Implementation CR467.1001.003
        public int tcoCalibrationDate { get; set; }

        public byte[] driverName { get; set; }

        public byte[] coDriverName { get; set; }

        //CR-474 Sprint 2 Implementation R-93 Traceablility code:CR474.1001.002
        public Boolean bIsStoreDriverName { get; set; }


        /// <summary>
        /// CR-481 R121 6.1	Driver Consent Information from DTCO 4.0 Traceablility code:CR481.1001.001
        /// </summary>
        public string consentITSSmartCardSlot1 { get; set; }
        public string consentVDOSmartCardSlot1 { get; set; }
        public string consentITSSmartCardSlot2 { get; set; }
        public string consentVDOSmartCardSlot2 { get; set; }

        /// <summary>
        /// CR 481 R-18 & 19 DTCO CAN2/MPDR data reading (Fuel) (from DTCO 2.2 up to DTCO 4.0) and FMS data reading on Vehicle FMS CAN Traceability Code: CR481.1001.004
        /// </summary>
        public List<CANMesageVO> FMDCanMsgList { get; set; }

        public List<CANMesageVO> FMSCanMsgList { get; set; }
    }

    /// <summary>
    /// CR 481 R-18 & 19 DTCO CAN2/MPDR data reading (Fuel) (from DTCO 2.2 up to DTCO 4.0) and FMS data reading on Vehicle FMS CAN Traceability Code: CR481.1001.004
    /// </summary>
    public class CANMesageVO
    {
        public byte[] PGNHex { get; set; }

        public byte[] PGNContent { get; set; }

    }
}