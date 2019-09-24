using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OpeningStock
    {
        public string OpeningStockId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? OpQty { get; set; }
        public decimal? OpValue { get; set; }
        public decimal? OpRate { get; set; }
        public string FinYearId { get; set; }
        public string BatchNo { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public DateTime? RecDt { get; set; }
        public DateTime? ExpDt { get; set; }
        public string LocationStat { get; set; }
        public string OrderId { get; set; }
        public string Ref { get; set; }
        public string Reason { get; set; }
        public decimal? Mrp { get; set; }
        public decimal? Tp { get; set; }
        public decimal? InvoiceRate { get; set; }
        public decimal? SopQty { get; set; }
        public decimal? SopVal { get; set; }
        public decimal? SopRate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
    }
}
