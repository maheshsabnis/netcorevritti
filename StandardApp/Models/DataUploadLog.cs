using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DataUploadLog
    {
        public string DataUploadLogId { get; set; }
        public string RefId { get; set; }
        public string RefType { get; set; }
        public string Reason { get; set; }
        public DateTime? UploadDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
