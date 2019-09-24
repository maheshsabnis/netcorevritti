using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PymtSettTermMaster
    {
        public decimal RecId { get; set; }
        public string PymtSettTermMasterId { get; set; }
        public string FinDivId { get; set; }
        public string PaymentorSttl { get; set; }
        public string TermsCode { get; set; }
        public string TermsDescription { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
