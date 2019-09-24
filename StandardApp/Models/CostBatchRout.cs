using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostBatchRout
    {
        public decimal CostBatchRoutId { get; set; }
        public string CostBatchHeaderId { get; set; }
        public decimal? RoutId { get; set; }
        public decimal? ItemsId { get; set; }
        public string ItemRoutingDetailId { get; set; }
        public decimal? RoutSeq { get; set; }
        public string MachineGroupId { get; set; }
        public decimal? NoOfMcnGrp { get; set; }
        public decimal? NoOfLabour { get; set; }
        public decimal? TimeReqdForrMcnGrp { get; set; }
        public decimal? TimeReqdForLabour { get; set; }
        public decimal? TimeUnitForMcnGrp { get; set; }
        public decimal? TimeUnitForLablor { get; set; }
        public decimal? ItemQty { get; set; }
        public decimal? Waste { get; set; }
        public decimal? StdCost { get; set; }
        public decimal? FtrCost { get; set; }
        public decimal? ThisMtrlCost { get; set; }
        public decimal? ThisOprCost { get; set; }
        public decimal? TillMtrlCost { get; set; }
        public decimal? TillOprCost { get; set; }
        public decimal? MtrlCostWaste { get; set; }
        public decimal? OprCostWaste { get; set; }
        public decimal? TotalOprCost { get; set; }
        public decimal? TotalMtrlCost { get; set; }
        public decimal? TotalWasteCost { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? Status { get; set; }
    }
}
