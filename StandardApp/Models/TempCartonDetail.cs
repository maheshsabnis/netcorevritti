using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TempCartonDetail
    {
        public string TempCartonDetailId { get; set; }
        public string TempCartonHeaderId { get; set; }
        public string BarcodeNo { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string TableNo { get; set; }
        public string ShiftNo { get; set; }
        public string Operator { get; set; }
    }
}
