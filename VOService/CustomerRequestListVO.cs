using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class CustomerRequestListVO
    {
        public String accountName { get; set; }
        public RequestListVO[] requestList { get; set; }
    }
}
