using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QuotationBom
    {
        public string QuotationBomid { get; set; }
        public string QuotationDtlId { get; set; }
        public string ItemMasterId { get; set; }
        public string Bomid { get; set; }
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
        public DateTime? ScheduleDate { get; set; }
        public DateTime? SailingDate { get; set; }
        public string PlantId { get; set; }
        public string WarehouseId { get; set; }
        public decimal? ReqQty { get; set; }
        public decimal? Moqty { get; set; }
        public decimal? ProductionQty { get; set; }
        public decimal? RejectionQty { get; set; }
        public decimal? ShipmentQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? LineTotal { get; set; }
        public string Uomid { get; set; }
        public string SpecCode { get; set; }
        public string SpecValue { get; set; }
    }
}
