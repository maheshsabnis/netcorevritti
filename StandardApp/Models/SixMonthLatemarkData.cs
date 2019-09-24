using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SixMonthLatemarkData
    {
        public string UserMasterId { get; set; }
        public decimal Year { get; set; }
        public decimal Session { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? TotalEl { get; set; }
        public string IsProc { get; set; }
    }
}
