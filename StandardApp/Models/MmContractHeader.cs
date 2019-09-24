using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmContractHeader
    {
        public string ContractHeaderId { get; set; }
        public string CustomerId { get; set; }
        public string ContractNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? ContractFromDt { get; set; }
        public DateTime? ContractToDt { get; set; }
        public string ContractStatus { get; set; }
        public DateTime? ContractTerminationDt { get; set; }
        public string TerminationReason { get; set; }
        public string OldContractNo { get; set; }
        public decimal? DetailAmt { get; set; }
        public decimal? TradeDiscount { get; set; }
        public decimal? TotalAmt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
