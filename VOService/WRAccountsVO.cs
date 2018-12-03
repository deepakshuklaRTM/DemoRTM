using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class WRAccountsVO
    {
        private AccountVO[] wRAccounts;

        public AccountVO[] WRAccounts
        {
            get { return wRAccounts; }
            set { wRAccounts = value; }
        }
        
    }
}
