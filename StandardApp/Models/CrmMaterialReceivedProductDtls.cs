using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMaterialReceivedProductDtls
    {
        public string PkmaterialRcvProDtlId { get; set; }
        public string FkmaterialReceiveDtlId { get; set; }
        public string FkproductId { get; set; }
        public decimal? Quantity { get; set; }
        public string AssetNo { get; set; }
    }
}
