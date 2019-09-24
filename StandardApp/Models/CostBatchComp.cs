using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchComp
    {
        public decimal CostBatchCompId { get; set; }
        public string CostBatchHeaderId { get; set; }
        public decimal? ItemsId { get; set; }
        public decimal? CompId { get; set; }
        public string ComponentId { get; set; }
        public string BomdetailId { get; set; }
        public string RoutingSeqId { get; set; }
        public decimal? QtyReqd { get; set; }
        public decimal? QtyPer { get; set; }
        public decimal? HqtyPer { get; set; }
        public string Bomuomid { get; set; }
        public decimal? StdCost { get; set; }
        public decimal? FtrCost { get; set; }
        public decimal? Status { get; set; }
    }
}
