using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Moheader
    {
        public string MoheaderId { get; set; }
        public string Mono { get; set; }
        public DateTime? Modate { get; set; }
        public string ItemProcessId { get; set; }
        public string Motype { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? Moqty { get; set; }
        public string PlantId { get; set; }
        public string WarehouseId { get; set; }
        public string SoheaderId { get; set; }
        public string SoscheduleId { get; set; }
        public DateTime? ScheduleStartDt { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string CreatedBy { get; set; }
        public bool? Mrprun { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string MoheaderStatus { get; set; }
        public string UommasterId { get; set; }
        public string PodetailId { get; set; }
        public string Moclassification { get; set; }
        public bool? ReleaseMo { get; set; }
        public decimal? MoqtyWithYield { get; set; }
        public decimal? ProdQty { get; set; }
        public string Comments { get; set; }
        public decimal? CrtnAlloctdQty { get; set; }
        public string IproutDtlId { get; set; }
        public string OproutDtlId { get; set; }
        public string IpmtrlCalcMode { get; set; }
        public decimal? PccardQty { get; set; }
        public decimal? PicklistQty { get; set; }
        public decimal? SecondsQty { get; set; }
        public decimal? ReworkQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? RejQty { get; set; }
        public decimal? ReqdQtyForPc { get; set; }
        public string LotNo { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public decimal? SizeVolume { get; set; }
        public string Ref { get; set; }
    }
}
