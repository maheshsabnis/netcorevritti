using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StockAdjustment
    {
        public string StockAdjId { get; set; }
        public string AdjNo { get; set; }
        public string ItemMasterId { get; set; }
        public string AdjType { get; set; }
        public decimal? AdjQty { get; set; }
        public decimal? OpRate { get; set; }
        public decimal? OpValue { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? FinYearId { get; set; }
        public DateTime? AdjDate { get; set; }
        public string BatchNo { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string CartonSrNo { get; set; }
        public string CartonNo { get; set; }
        public string PacketMasterId { get; set; }
    }
}
