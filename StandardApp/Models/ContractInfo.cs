using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ContractInfo
    {
        public decimal RecId { get; set; }
        public string ContractInfoId { get; set; }
        public string ContractNo { get; set; }
        public string Entity { get; set; }
        public string CapexFormMasterId { get; set; }
        public string FinDivId { get; set; }
        public DateTime? ContractDt { get; set; }
        public DateTime? ValidFm { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CurrCode { get; set; }
        public decimal? ContractAmtFc { get; set; }
        public decimal? ExRate { get; set; }
        public decimal? ContractAmt { get; set; }
        public string ContractDesc { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
