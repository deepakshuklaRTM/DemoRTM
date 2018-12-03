using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VOService
{
    public class DLDDetailsUIVO
    {
        /**
	 * 
	 */
        private static long serialVersionUID = 1L;
        private String cmdName;

        public String CmdName
        {
            get { return cmdName; }
            set { cmdName = value; }
        }
        private String serialId;
        private int status;
        private String downloadTime;

        public String DownloadTime
        {
            get { return downloadTime; }
            set { downloadTime = value; }
        }

        private string wLANSettingName;

        public string WLANSettingName
        {
            get { return wLANSettingName; }
            set { wLANSettingName = value; }
        }
        private String iP;

        public String IP
        {
            get { return iP; }
            set { iP = value; }
        }
        private int installationDate;

        public int InstallationDate
        {
            get { return installationDate; }
            set { installationDate = value; }
        }
        private String swVersion;

        public String SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }


        public String SwVersion
        {
            get { return swVersion; }
            set { swVersion = value; }
        }

        // R-64 Chunk Size Implementation
        public string chunkSize { get; set; }

        // R-99 vehicle type Implementation
        public int? vehicleType { get; set; }
        public byte[] vrn { get; set; }
        public byte[] vin { get; set; }
        // R-106 Change
        public bool alcDevice { get; set; }

    }
    //CR 474 AUTOMATIC ADDITION OF WR DLD II R-90 Traceablity Code: CR474.1001.001
    public class AssetPoolDLDDetails
    {
        public string serialId { get; set; }
        public string chunkSize { get; set; }
        public int? VEHICLE_TYPE { get; set; }
        public string VAN_TRAILER_VRN { get; set; }
        public bool alcDevice { get; set; }
        public int status { get; set; }
        public string asVersion { get; set; }
        public string bsVersion { get; set; }
        public string simId { get; set; }
        public string imei { get; set; }
        public string msisdn { get; set; }
        public string simPin { get; set; }
        public string simPuk { get; set; }
        public string apnName { get; set; }
        public string apnUserName { get; set; }
        public string apnPassword { get; set; }
        public string protocolVersion { get; set; }
        public string sleepTime { get; set; }
        public string driverCardNo { get; set; }
        public string coDriverCardNo { get; set; }
        public string VAN_TRAILER_VIN { get; set; }

    }

    public class ALCVO
    {
        public string dldSerialID { get; set; }
        // public byte[] alcDriverNumber { get; set; }
        public Int16 lastAlcEvent { get; set; }
        public long lastEventTimestamp { get; set; }

        //**CR 467 R - 134 Implementation Traceability Code: CR467.1001.004**//
        public byte[] vrn { get; set; }
        public byte[] driverID1 { get; set; }
    }

    public class VehicleHistory
    {
        public string LastVRN { get; set; }
        public string LastDriverCardNo { get; set; }
    }

    // R-129 Change CR467.1001.003
    public class DLDConnectedVO
    {
        public byte[] VRN { get; set; }
        public byte[] VIN { get; set; }
        public string SerialId { get; set; }
        public byte[] DriverNumber { get; set; }
        public byte[] CoDriverNumber { get; set; }
        public int DldConnectedFlag { get; set; }

        public string ProtocolVersion { get; set; }

        public long? CalibrationDate { get; set; }
        public string DTCOVersion { get; set; }
        public byte[] DriverName1 { get; set; }
        public byte[] DriverName2 { get; set; }

        public byte[] Passkey { get; set; }

    }
}