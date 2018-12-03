using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class CompanyCardVO
    {

        static long serialVersionUID = 1;
        private int accountID;

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        private int cardState;
        public int CardState
        {
            get { return cardState; }
            set { cardState = value; }
        }
        private String termnial;
        public String Termnial
        {
            get { return termnial; }
            set { termnial = value; }
        }
        
        public int cardType { get; set; }
        private String reservedTimestamp = null;
        public String ReservedTimestamp
        {
            get { return reservedTimestamp; }
            set { reservedTimestamp = value; }
        }
        public string sCompanyCardSerialNo { get; set; }
        public int getid { get; set; }
        public int siteID { get; set; }
        public DateTime dStartDate { get; set; }
        public DateTime dExpiryDate { get; set; }
        public string cardNumber { get; set; }
        public int iMemberCodeID { get; set; }

        public CompanyCardDetails[] CompanyCardDetails
        { get; set; }

        public List<CompanyCardDetails> lstCompanyCardDetails
        { get; set; }

    }

    }


