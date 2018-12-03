/**************************************************************************************************************************************************** 
* Traceablity Key: CR414.1001.002 
* R-27
* PURPOSE:  R-27 Additional information for GPS records
* MODIFIED DATE: 26-04-2016
*****************************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class CommandGPSDDataVO_1b1_5_5
    {

        public string seqId { get; set; }
        public string gpsPosition { get; set; }
        public string numberGPS { get; set; }
        public int iTimeStamp { get; set; }
        public float fLatitude { get; set; }
        public float fLongitude { get; set; }
        public float fAltitude { get; set; }
        public float fHeadingChange { get; set; }
        public float fSpeed { get; set; }

        /*Tracibility Key CR414.1001.002*/
        /*R-27 Additional information for GPS records*/
        public int DLDTimeStamp { get; set; }
        public string DTCOTimestamp { get; set; }
        public string DTCOOdometer { get; set; }
        public string DTCOVRN { get; set; }
        public string DTCOVIN { get; set; }
        public string DTCODriver1ID { get; set; }
        public string DTCODriver1Activity { get; set; }
        public string DTCODriver2ID { get; set; }
        public string DTCODriver2Activity { get; set; }
        public string DTCOvehiclespeed { get; set; }
        public string DTCOenginespeed { get; set; }  
        /*------------------------------------*/











    }
}
