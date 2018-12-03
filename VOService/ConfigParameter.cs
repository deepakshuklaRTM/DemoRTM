using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class ConfigParameter
    {
        public String SRCommServiceStatusUpdateFreqMin{ get; set; }
        
        public String SRCommDLDStatusUpdateFreqMin { get; set; }
        
        public String AuthSocketTimeoutSec { get; set; }
        
        public String AuthRTMMessageIntervalSec { get; set; }
        
        public String AuthCompanyCardDetectionFreqSec { get; set; }
        
        public String AuthUnexpectedAuthenticationInProgressFreqMin { get; set; }
        
        public String AuthXmlUpdateIntervalMin { get; set; }

        public String AuthCSVSRetryPeriodFreqSec { get; set; }
        
        public String AuthRDSPingFreqSec { get; set; }
        
    }
}
