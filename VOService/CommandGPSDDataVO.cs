using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class CommandGPSDDataVO
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

    }
}
