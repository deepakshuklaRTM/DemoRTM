using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class DownloadList
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string PathName { get; set; }
        public DownloadList()
        {

        }

        public DownloadList(string FileName, DateTime CreatedDate, string Path)
        {
            Name = FileName;
            CreationDate = CreatedDate;
            PathName = Path;
        }
    }

    public enum StatusCode
    {
        Success=0 , // Success Case
        FileNoExists=1, //If no file exist for period selected than RC=1
        DateGreater =2, // If From Date is greater than To Date than, no file will returned (RC=2)
        ParameterBlank =3, // If any mandatory parameter, null or blank, than no file will be returned (RC=3).
        OptionalIsNull =4, // If Optional parameter(s) is null than download all file not yet downloaded (RC=4).
        InvalidCredential = 5 // If user credentials are not valid, than no file will be returned (RC=5).
    }

    public class DownloadStatus
    {
        public string FileName { get; set; }
        public int Status { get; set; }
    }
}
