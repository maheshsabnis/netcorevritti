using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PochargeTaxLine
    {
        public string PochargeTaxLineId { get; set; }
        public string PochargeDetailId { get; set; }
        public decimal? SeqNo { get; set; }
        public string TaxMasterId { get; set; }
        public decimal? TaxPc { get; set; }
        public bool? Invoiced { get; set; }
        public string LineNumber { get; set; }
        public decimal? TaxCalcId { get; set; }
        public string BaseAmount { get; set; }
        public string PayableAccount { get; set; }
        public string ReceivableAccount { get; set; }
        public decimal? BaseAmntPercForTaxCalc { get; set; }
        public decimal? MinAmntAllowedForTaxCalc { get; set; }
        public string OppositeInvoicedGl { get; set; }
        public bool? Recoverable { get; set; }
        public decimal? TaxAmount { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
