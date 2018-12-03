using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class VU
    {
        static long serialVersionUID = 1;

        public static long SerialVersionUID
        {
            get { return VU.serialVersionUID; }
            set { VU.serialVersionUID = value; }
        }
        private String vUActivityBlock;

        public String VUActivityBlock
        {
            get { return vUActivityBlock; }
            set { vUActivityBlock = value; }
        }
        private String vUSpeedBlockArchive;

        public String VUSpeedBlockArchive
        {
            get { return vUSpeedBlockArchive; }
            set { vUSpeedBlockArchive = value; }
        }
        private String vUTechnicalBlockArchive;

        public String VUTechnicalBlockArchive
        {
            get { return vUTechnicalBlockArchive; }
            set { vUTechnicalBlockArchive = value; }
        }
        private String vUEventFaultBlockArchive;

        public String VUEventFaultBlockArchive
        {
            get { return vUEventFaultBlockArchive; }
            set { vUEventFaultBlockArchive = value; }
        }
    }
}
