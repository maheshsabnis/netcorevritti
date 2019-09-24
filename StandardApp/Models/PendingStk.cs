using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PendingStk
    {
        public string StockDetailsId { get; set; }
        public decimal? UnPostedQty { get; set; }
    }
}
