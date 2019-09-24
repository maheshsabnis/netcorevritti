using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DailyTinshedstk
    {
        public DateTime StkDt { get; set; }
        public string PcmasterId { get; set; }
        public string OperationId { get; set; }
        public decimal? Qty { get; set; }
        public string WiplocationId { get; set; }
    }
}
