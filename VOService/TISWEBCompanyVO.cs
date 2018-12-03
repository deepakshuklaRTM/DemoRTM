using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class TISWEBCompanyVO
    {
        public string sCompanyCardSerialNo { get; set; }
        public int? siteID { get; set; }
        public DateTime? dStartDate { get; set; }
        public DateTime? dExpiryDate { get; set; }
        public string cardNumber { get; set; }
        public int? iMemberCodeID { get; set; }
    }
}
