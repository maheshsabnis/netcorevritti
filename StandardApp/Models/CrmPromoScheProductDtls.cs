using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmPromoScheProductDtls
    {
        public string PkpromoScheProdctId { get; set; }
        public string FkpromoSchemeId { get; set; }
        public string FkproductId { get; set; }
        public decimal? PromotionalPrice { get; set; }
        public decimal? PromotionalDiscount { get; set; }
        public decimal? MinimumQty { get; set; }
        public decimal? MinimumValue { get; set; }
        public bool? IsActive { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
