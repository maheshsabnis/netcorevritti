using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemDemand
    {
        public decimal ItemDemandId { get; set; }
        public string Mrpid { get; set; }
        public string ItemMasterId { get; set; }
        public DateTime? ReqmntDt { get; set; }
        public decimal? DebitType { get; set; }
        public string OrderId { get; set; }
        public decimal? QtyReqd { get; set; }
    }
}
