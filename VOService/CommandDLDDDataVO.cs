using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class CommandDLDDDataVO
    {
        public int accountID { get; set; }
        public string dataSource { get; set; }
        public int dldTimeStamp { get; set; }
        public string dtcoVRN { get; set; }
        public string dtcoVIN { get; set; }
        public string dtcoDriver1ID { get; set; }
        public string DriverCardIssuingMemberState { get; set; }
        public string dtcoDriver2ID { get; set; }
        public string CoDriverCardIssuingMemberState { get; set; }
        public short eventCode { get; set; }
        public string PGNHex { get; set; }
        public string PGNContent { get; set; }

    }
}
