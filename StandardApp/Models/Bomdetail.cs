using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Bomdetail
    {
        public string BomdetailId { get; set; }
        public string BomheaderId { get; set; }
        public string ComponentId { get; set; }
        public decimal? QtyReqd { get; set; }
        public decimal? QtyPer { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string UsedAtOperationSeq { get; set; }
        public string CummuYeildAtOperationSeq { get; set; }
        public decimal? StdMatlCostThis { get; set; }
        public decimal? FutureMatlCostThis { get; set; }
        public decimal? StdMatlCostLower { get; set; }
        public decimal? FutureMatlCostLower { get; set; }
        public bool? BackFlushing { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UommasterId { get; set; }
        public bool? ByProduct { get; set; }
        public string PositionId { get; set; }
        public string ItemClassificationId { get; set; }
        public string Margin { get; set; }
        public string Bomsequence { get; set; }
        public string Variable { get; set; }
        public string Mandatory { get; set; }
        public string AllowMultiple { get; set; }
    }
}
