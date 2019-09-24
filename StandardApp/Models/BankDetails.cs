using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BankDetails
    {
        public decimal RecId { get; set; }
        public string BankDetailsId { get; set; }
        public string BankMasterId { get; set; }
        public decimal? ChequeBookStartNo { get; set; }
        public decimal? ChequeBookEndNo { get; set; }
        public decimal? ChequeBookLeaf { get; set; }
        public DateTime? IssueDate { get; set; }
        public string InUse { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
