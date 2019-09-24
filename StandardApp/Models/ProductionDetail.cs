using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProductionDetail
    {
        public string ProductionDetailId { get; set; }
        public string ProductionHeaderId { get; set; }
        public string MoheaderId { get; set; }
        public decimal? Moqty { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? RejQty { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string LotNo { get; set; }
        public DateTime? Fifodt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string EnterBy { get; set; }
        public decimal? ExcessConsQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? SecondItemQty { get; set; }
        public string ExcessConsItemId { get; set; }
        public string ScrapItemId { get; set; }
        public decimal? FirstQltExcess { get; set; }
        public decimal? FirstQltExcessQty { get; set; }
        public string SemifinishedId { get; set; }
        public string RefRecType { get; set; }
        public string RefRecId { get; set; }
        public decimal? NextStageQty { get; set; }
        public string ItemMasterId { get; set; }
        public string RecType { get; set; }
        public string PlantMasterId { get; set; }
        public string ShiftMasterId { get; set; }
        public string ReasonBalQty { get; set; }
        public string RouteName { get; set; }
        public string SegmentType { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
    }
}
