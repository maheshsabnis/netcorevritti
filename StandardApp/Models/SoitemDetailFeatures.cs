using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SoitemDetailFeatures
    {
        public string SoitmDtlFechr { get; set; }
        public string SoDetailId { get; set; }
        public string BomdetailId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? QtyReqd { get; set; }
    }
}
