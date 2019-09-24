using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaxCalculation
    {
        public string TaxCalculationId { get; set; }
        public decimal? SeqNo { get; set; }
        public string TaxClassMasterId { get; set; }
        public string TaxMasterId { get; set; }
        public decimal? TaxPc { get; set; }
        public bool? Invoiced { get; set; }
        public string LineNumber { get; set; }
        public string TaxCalcId { get; set; }
        public string BaseAmount { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PayableAccount { get; set; }
        public string ReceivableAccount { get; set; }
        public decimal? BaseAmntPercForTaxCalc { get; set; }
        public decimal? MinAmntAllowedForTaxCalc { get; set; }
        public string OppositeInvoicedGl { get; set; }
        public bool? Recoverable { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveUpto { get; set; }
        public string Module { get; set; }
    }
}
