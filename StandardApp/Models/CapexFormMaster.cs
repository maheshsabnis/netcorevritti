using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CapexFormMaster
    {
        public decimal RecId { get; set; }
        public string CapexFormMasterId { get; set; }
        public string FinDivId { get; set; }
        public string CapexNo { get; set; }
        public string FormNo { get; set; }
        public string Description { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? ValidUpto { get; set; }
        public decimal? Amount { get; set; }
        public string IsBudgeted { get; set; }
        public string StatusId { get; set; }
        public string GeneratedBy { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? ProcAmnt { get; set; }
        public string CurrencyMasterId { get; set; }
        public decimal? AmountFc { get; set; }
        public decimal? ExRate { get; set; }
    }
}
