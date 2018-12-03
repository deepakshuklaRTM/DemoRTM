using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class AccountDetailsXMLParent
    {
        private AccountsDetailsXMLChild[] accounts;

        public AccountsDetailsXMLChild[] Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

    }
}
