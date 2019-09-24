using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostRate
    {
        public string CostRateId { get; set; }
        public decimal? RecType { get; set; }
        public decimal? RefRecType { get; set; }
        public string RefRecId { get; set; }
        public string CostHeadMasterId { get; set; }
        public DateTime? EffFrom { get; set; }
        public decimal? TimePeriod { get; set; }
        public decimal? TimeUnit { get; set; }
        public decimal? Qty { get; set; }
        public decimal? StdValue { get; set; }
        public decimal? FtrValue { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }

        public virtual CostHeadMaster CostHeadMaster { get; set; }
    }
}
