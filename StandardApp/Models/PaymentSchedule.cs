using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PaymentSchedule
    {
        public string PaymentScheduleId { get; set; }
        public string SoheaderId { get; set; }
        public DateTime? ChequeDate { get; set; }
        public decimal? Amount { get; set; }
        public string ChequeNo { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public DateTime? ClearanceDate { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsClear { get; set; }
        public string Micr { get; set; }
        public string BankSlipNo { get; set; }
        public DateTime? BankSlipDate { get; set; }
    }
}
