using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class SiteDetailsXMLChild
    {
        public int iSiteId { get; set; }
        public int iAccountId { get; set; }
        public string sReference { get; set; }
        public string sSiteDesc { get; set; }
        public string sComment { get; set; }
        public string sAddress1 { get; set; }
        public string sAddress2 { get; set; }
        public string sPostalCode { get; set; }
        public string sLocation { get; set; }
        public string sEmail { get; set; }
        public string sTelephoneNo { get; set; }
        public string sFax { get; set; }
        public string sContactNumber { get; set; }
        public Boolean bIsActive { get; set; }
        public Boolean bIsDisabled { get; set; }
    }
}
