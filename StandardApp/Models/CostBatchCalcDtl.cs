using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchCalcDtl
    {
        public decimal CostBatchCalcDtlId { get; set; }
        public string CostBatchHeaderId { get; set; }
        public decimal? ItemsId { get; set; }
        public decimal? CompId { get; set; }
        public decimal? RoutId { get; set; }
        public string CostRateId { get; set; }
        public decimal? ActStdCost { get; set; }
        public decimal? ActFtrCost { get; set; }
        public decimal? StdCost { get; set; }
        public decimal? FtrCost { get; set; }
        public decimal? Status { get; set; }
    }
}
