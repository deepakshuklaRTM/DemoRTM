using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class ServiceVO
    {
        static long serialVersionUID = 1;
        private int iServiceID;

        public int IServiceID
        {
            get { return iServiceID; }
            set { iServiceID = value; }
        }
        private int sServiceTypeId;

        public int SServiceTypeId
        {
            get { return sServiceTypeId; }
            set { sServiceTypeId = value; }
        }
        private String sVersion;

        public String SVersion
        {
            get { return sVersion; }
            set { sVersion = value; }
        }
        private int iServiceStatusID;

        public int IServiceStatusID
        {
            get { return iServiceStatusID; }
            set { iServiceStatusID = value; }
        }
        private Boolean bIsServiceActivated;

        public Boolean BIsServiceActivated
        {
            get { return bIsServiceActivated; }
            set { bIsServiceActivated = value; }
        }
        private Boolean bIsServiceInstalled;

        public Boolean BIsServiceInstalled
        {
            get { return bIsServiceInstalled; }
            set { bIsServiceInstalled = value; }
        }
    }
}
