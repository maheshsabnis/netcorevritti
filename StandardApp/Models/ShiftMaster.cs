using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ShiftMaster
    {
        public string ShiftMasterId { get; set; }
        public string ShiftCode { get; set; }
        public string ShiftDesc { get; set; }
        public string ShiftStartTime { get; set; }
        public string ShiftEndTime { get; set; }
        public decimal? ShiftTimeInHr { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public TimeSpan? GraceTime { get; set; }
        public decimal? BreakHrs { get; set; }
        public decimal? TotalProdHrs { get; set; }
    }
}
