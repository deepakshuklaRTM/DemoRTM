using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class SV
    {
        static long serialVersionUID = 1;

        public static long SerialVersionUID
        {
            get { return SV.serialVersionUID; }
            set { SV.serialVersionUID = value; }
        }
        private String sVDetailedDataBlock;

        public String SVDetailedDataBlock
        {
            get { return sVDetailedDataBlock; }
            set { sVDetailedDataBlock = value; }
        }
        private String sVSplDataBlock;

        public String SVSplDataBlock
        {
            get { return sVSplDataBlock; }
            set { sVSplDataBlock = value; }
        }
        private String sVMultiPurposeDataBlock;

        public String SVMultiPurposeDataBlock
        {
            get { return sVMultiPurposeDataBlock; }
            set { sVMultiPurposeDataBlock = value; }
        }
    }
}
