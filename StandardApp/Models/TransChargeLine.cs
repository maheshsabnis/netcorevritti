﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransChargeLine
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransChargeId { get; set; }
        public string FinDivId { get; set; }
        public string ChrgLineNo { get; set; }
        public string ChargeId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public decimal? LineQty { get; set; }
        public decimal? LoadedValue { get; set; }
        public decimal? LinePrice { get; set; }
        public decimal? LineExt { get; set; }
        public decimal? LineDiscPer { get; set; }
        public decimal? LineDiscVal { get; set; }
        public decimal? LineValue { get; set; }
        public decimal? LineValueFc { get; set; }
        public string LineNarrative { get; set; }
        public string AllowSettlementDisc { get; set; }
        public string LineUnit { get; set; }
        public string LineAccountId { get; set; }
        public string LineAccType { get; set; }
        public string LineAccPeriod { get; set; }
        public string LineApportionmentId { get; set; }
        public string SubToWithHolding { get; set; }
        public string ItemTaxClassId { get; set; }
        public string TaxIndicator { get; set; }
        public string TaxTxnType { get; set; }
        public string LineItemId { get; set; }
        public string AccMethodTo { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderLineNo { get; set; }
        public string OrderNo { get; set; }
        public string WithHoldingMethod { get; set; }
        public string WithHoldingMethodId { get; set; }
        public DateTime? OrigDocDt { get; set; }
        public string OrigDocNo { get; set; }
        public string LcentryId { get; set; }
        public string SourceId { get; set; }
        public string SourceType { get; set; }
        public string IsAutoGenerated { get; set; }
        public string NarrativeId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string VendorName { get; set; }
        public string Gstin { get; set; }
    }
}
