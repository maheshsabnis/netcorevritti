using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemProcess
    {
        public string ItemProcessId { get; set; }
        public string ItemProcessCode { get; set; }
        public string ItemMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string ProcessDesc { get; set; }
        public string ProductionLineMasterId { get; set; }
        public string Bomid { get; set; }
        public string RoutingId { get; set; }
        public string ByProductsDetailId { get; set; }
        public decimal? StdOutputRate { get; set; }
        public decimal? FutureOutputRate { get; set; }
        public string StdOutputRatePer { get; set; }
        public string FutureOutputRatePer { get; set; }
        public bool? StdPrimaryProcessFor { get; set; }
        public bool? FuturePrimaryProcess { get; set; }
        public decimal? StdLotSize { get; set; }
        public decimal? FutureLotSize { get; set; }
        public decimal? StdPurMtrlCost { get; set; }
        public decimal? FuturePurMtrlCost { get; set; }
        public decimal? StdMfgMtrlCost { get; set; }
        public decimal? FutureMfgMtrlCost { get; set; }
        public decimal? StdCummulativeYield { get; set; }
        public decimal? FutureCummulativeYield { get; set; }
        public decimal? StdScrapRealization { get; set; }
        public decimal? FutureScrapRealization { get; set; }
        public decimal? StdNetCost { get; set; }
        public decimal? FutureNetCost { get; set; }
        public bool? Osp { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PrimProcForCosting { get; set; }
        public string DoProdEntry { get; set; }
    }
}
