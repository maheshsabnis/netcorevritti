using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PaymentBatchDetails
    {
        public string BatchDetailId { get; set; }
        public string BatchHeaderId { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string TransHeaderId { get; set; }
        public string TransSettlementLinesId { get; set; }
        public decimal? Amount { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? BalanceAmt { get; set; }
        public string TransNo { get; set; }
    }
}
