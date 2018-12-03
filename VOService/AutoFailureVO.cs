using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class AutoFailureVO
    {
        public int timeStamp { get; set; }
        public byte errorCode { get; set; }
        public byte errorType { get; set; }
        public string cmdSequenceId { get; set; }
        public string dldType { get; set; }
        public int iDLDErrorTypeId { get; set; }
    }
}
