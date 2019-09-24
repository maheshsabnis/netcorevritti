using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemCredit
    {
        public decimal ItemCreditId { get; set; }
        public string Mrpid { get; set; }
        public string ItemMasterId { get; set; }
        public DateTime? QtyOnDate { get; set; }
        public decimal? CreditType { get; set; }
        public string OrderId { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? StockQty { get; set; }
        public decimal? ReqQty { get; set; }
    }
}
