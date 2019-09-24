using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMaterialMovementProductDtls
    {
        public string PkmaterialMoveDtlId { get; set; }
        public string FkmaterialMoveId { get; set; }
        public string FkproductId { get; set; }
        public decimal? Quantity { get; set; }
        public string AssetNo { get; set; }
    }
}
