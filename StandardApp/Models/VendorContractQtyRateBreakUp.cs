using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VendorContractQtyRateBreakUp
    {
        public string VendorContractQtyRateBreakUpId { get; set; }
        public string VendorContractDetailId { get; set; }
        public string ItemMasterId { get; set; }
        public string QtyUpto { get; set; }
        public string Rate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
