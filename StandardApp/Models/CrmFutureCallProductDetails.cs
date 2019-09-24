using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmFutureCallProductDetails
    {
        public string PkCallProductId { get; set; }
        public string CallId { get; set; }
        public string FkProductId { get; set; }
        public int? Quantity { get; set; }
        public string FkfuturePlanId { get; set; }
    }
}
