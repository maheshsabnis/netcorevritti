using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesBillDtlTaxLine
    {
        public decimal SalesBillDtlTaxLineId { get; set; }
        public decimal? SalesBillDtlId { get; set; }
        public decimal? TaxMasterId { get; set; }
        public decimal? TaxPc { get; set; }
        public bool? Invoiced { get; set; }
        public string BaseAmountType { get; set; }
        public decimal? BaseAmount { get; set; }
        public decimal? TaxAmount { get; set; }
    }
}
