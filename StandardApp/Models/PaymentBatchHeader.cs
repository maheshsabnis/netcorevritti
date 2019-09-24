using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PaymentBatchHeader
    {
        public string BatchHeaderId { get; set; }
        public string BatchNo { get; set; }
        public decimal? Amount { get; set; }
        public string Createdby { get; set; }
        public string BatchStatus { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
