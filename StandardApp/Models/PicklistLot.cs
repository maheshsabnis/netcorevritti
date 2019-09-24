using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PicklistLot
    {
        public string PicklistLotId { get; set; }
        public string PicklistDtlId { get; set; }
        public string StockDtlId { get; set; }
        public decimal? PickQty { get; set; }
    }
}
