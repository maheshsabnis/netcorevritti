using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CenvatServiceTaxInfo
    {
        public decimal? RecId { get; set; }
        public string FinDivId { get; set; }
        public string CenvatServTaxInfoId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransNo { get; set; }
        public DateTime? EffDate { get; set; }
        public string RefTransHeaderId { get; set; }
        public string RefTransNo { get; set; }
        public string BillInvNo { get; set; }
        public DateTime? BillInvDt { get; set; }
        public string PartyId { get; set; }
        public string PartyName { get; set; }
        public decimal? PersonalLdgrValue { get; set; }
        public decimal? ServTaxAmt { get; set; }
        public string IsPaid { get; set; }
        public string PymtTransNo { get; set; }
        public decimal? PaidAmt { get; set; }
        public string IsCreditTaken { get; set; }
        public string ExciseNo { get; set; }
        public string RefundClaimNo { get; set; }
        public string TransStatus { get; set; }
        public string Narration { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
