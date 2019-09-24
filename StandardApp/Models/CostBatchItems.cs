using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchItems
    {
        public decimal CostBatchItemsId { get; set; }
        public string CostBatchHeaderId { get; set; }
        public decimal? ItemsId { get; set; }
        public string ItemProcessId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? StdCost { get; set; }
        public decimal? FtrCost { get; set; }
        public decimal? FinalCost { get; set; }
        public decimal? Status { get; set; }
    }
}
