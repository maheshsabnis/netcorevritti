using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ResourceCost
    {
        public string ResourceCostId { get; set; }
        public string EmpId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? RatePerHour { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsClosed { get; set; }
    }
}
