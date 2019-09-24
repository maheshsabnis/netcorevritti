using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmSuspProdctDtls
    {
        public string PkprospectProductDtlsId { get; set; }
        public string FksuspectId { get; set; }
        public string FkproductId { get; set; }
        public string PurchaseMode { get; set; }
        public string Uomid { get; set; }
        public decimal? Qty { get; set; }
    }
}
