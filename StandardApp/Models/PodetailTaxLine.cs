using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PodetailTaxLine
    {
        public string PodetailTaxLineId { get; set; }
        public string PodetailId { get; set; }
        public string TaxMasterId { get; set; }
        public decimal? TaxPc { get; set; }
        public bool? Invoiced { get; set; }
        public string BaseAmountType { get; set; }
        public decimal? BaseAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? SeqNo { get; set; }
        public string LineNumber { get; set; }
        public decimal? BaseAmntPercForTaxCalc { get; set; }
        public decimal? MinAmntAllowedForTaxCalc { get; set; }
        public string OppositeInvoicedGl { get; set; }
        public string PayableAccount { get; set; }
        public string ReceivableAccount { get; set; }
        public bool? Recoverable { get; set; }
        public decimal? TaxCalcId { get; set; }
    }
}
