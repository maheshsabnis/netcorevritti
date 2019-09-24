using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemStockStatus
    {
        public string ItemPlantId { get; set; }
        public decimal? StockQty { get; set; }
        public decimal? AllocQty { get; set; }
        public decimal? SbcstockQty { get; set; }
        public decimal? SbcallocQty { get; set; }
    }
}
