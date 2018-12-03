using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class SiteVO
    {   
        public string  sReference { get; set; }
        public string sSiteDesc { get; set; }
        public string sAddress1 { get; set; }
        public string sAddress2 { get; set; }
        public string sPostalCode { get; set; }
        public string sEmail { get; set; }
        public string sTelephoneNo { get; set; }
        public string sFax { get; set; }
        public string sContactNumber { get; set; }
        public string  sName { get; set; }
        public Boolean bIsBaseSite { get; set; }
        public int iCustDBSiteId { get; set; }
        public string sComment { get; set; }
        
    }
}
