using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransTaxLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransTaxLinesId { get; set; }
        public string TransChargeLineId { get; set; }
        public string FinDivId { get; set; }
        public string TaxLineNo { get; set; }
        public string TaxCode { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? TaxSeqNo { get; set; }
        public string TaxCodeResultId { get; set; }
        public string TaxIndicator { get; set; }
        public DateTime? TaxEffDt { get; set; }
        public string TaxTxnType { get; set; }
        public string InvTaxSuffix { get; set; }
        public string ShipToNo { get; set; }
        public string OrderNumber { get; set; }
        public string ShipToSuffix { get; set; }
        public string VendorId { get; set; }
        public string TaxLineNarrative { get; set; }
        public string TaxLineSource { get; set; }
        public string ItemId { get; set; }
        public string ItemTaxClassId { get; set; }
        public string ChargeId { get; set; }
        public string SpecialChargeId { get; set; }
        public string WarehouseId { get; set; }
        public decimal? OrderQty { get; set; }
        public string Uomid { get; set; }
        public decimal? OriginChrgAmt { get; set; }
        public decimal? CashDiscPer { get; set; }
        public decimal? CashDiscAmt { get; set; }
        public string TaxAdjForCashDisc { get; set; }
        public string TaxInPriceCalcType { get; set; }
        public decimal? CompTaxUplift { get; set; }
        public string CompTaxUplifTaxId { get; set; }
        public decimal? CompTaxUpliftResult { get; set; }
        public string TaxBaseAmtSub { get; set; }
        public string TaxRateSub { get; set; }
        public decimal? LineTaxRate { get; set; }
        public string TaxRateMethod { get; set; }
        public decimal? TaxRecoPer { get; set; }
        public string IncludeTaxInCashDisc { get; set; }
        public string TaxGroupCode { get; set; }
        public string UseTax { get; set; }
        public string EcmemoTax { get; set; }
        public string TaxRateDerived { get; set; }
        public string InfoOnlyTax { get; set; }
        public string IsTaxInvoiced { get; set; }
        public string TaxAccId { get; set; }
        public string DiscAccId { get; set; }
        public string WriteOffAccId { get; set; }
        public string AdjAccId { get; set; }
        public string MemoLiabRecAccId { get; set; }
        public string MemoOffsetAccId { get; set; }
        public string NonRecoVataccId { get; set; }
        public decimal? TaxLineTaxableVal { get; set; }
        public decimal? TaxAmt { get; set; }
        public decimal? TaxAmtFc { get; set; }
        public decimal? TaxExclPrice { get; set; }
        public decimal? TaxInclPrice { get; set; }
        public string OriginTaxBase { get; set; }
        public decimal? RecoTaxBaseAmt { get; set; }
        public decimal? RecoTaxAmt { get; set; }
        public decimal? EffTaxRate { get; set; }
        public string NarrativeId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
