using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Fatrans
    {
        public decimal RecId { get; set; }
        public string FatransId { get; set; }
        public string TransHeaderId { get; set; }
        public string AssetNo { get; set; }
        public string FarecFlag { get; set; }
        public string TransChargeId { get; set; }
    }
}
