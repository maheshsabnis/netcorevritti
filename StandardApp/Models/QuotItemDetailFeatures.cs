using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QuotItemDetailFeatures
    {
        public string QuoItmDtlFechr { get; set; }
        public string QuoDetailId { get; set; }
        public string BomdetailId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? QtyReqd { get; set; }
        public string IsDeleted { get; set; }
    }
}
