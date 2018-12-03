using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class TISWEBFrequencyFileExt
    {

        public int iVUReportDownloadReminderDuration { get; set; }
        public int eVUReportDownloadReminderPeriod { get; set; }
        public int iDCReportDownloadReminderDuration { get; set; }
        public int eDCReportDownloadReminderPeriod { get; set; }
        public int iSDDownloadReminderDuration { get; set; }
        public int eSDDownloadReminderPeriod { get; set; }
        public int eDriverCardFileSuffix { get; set; }
        public int eVehicleUnitFileSuffix { get; set; }
        public int eSVFileSuffix { get; set; }
    }
}
