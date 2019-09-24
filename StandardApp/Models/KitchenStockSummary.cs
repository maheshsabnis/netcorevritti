using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class KitchenStockSummary
    {
        public string KitchenStockSummaryId { get; set; }
        public string ItemMasterId { get; set; }
        public DateTime? EffDate { get; set; }
        public decimal? OpeningQty { get; set; }
        public decimal? ReceiptQty { get; set; }
        public decimal? ConsumptionQty { get; set; }
        public decimal? ClosingQty { get; set; }
        public decimal? PhysClosingQty { get; set; }
        public decimal? Difference { get; set; }
        public decimal? PurchaseRate { get; set; }
    }
}
