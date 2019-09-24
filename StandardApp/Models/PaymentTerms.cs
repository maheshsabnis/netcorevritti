using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PaymentTerms
    {
        public string PaymentTermsId { get; set; }
        public string SoheaderId { get; set; }
        public string PaymentTerms1 { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string AdvisingBank { get; set; }
        public string IssuingBank { get; set; }
        public string PaymentDueDate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? PaymentDueDt { get; set; }
    }
}
