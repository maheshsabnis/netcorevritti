using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ObMerchantPriceList
    {
        public string ObMerchantPriceListId { get; set; }
        public string CustVendorMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? ItemPrice { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool? IsActive { get; set; }
    }
}
