using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ServTaxInfo
    {
        public decimal RecId { get; set; }
        public string ServTaxInfoId { get; set; }
        public string TransHeaderId { get; set; }
        public string VoucherNo { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDt { get; set; }
        public decimal? Amnt { get; set; }
        public string RltvVoucherNo { get; set; }
        public decimal? PaidAmnt { get; set; }
        public string ExciseNo { get; set; }
        public string RefundClaimNo { get; set; }
        public string IsPaid { get; set; }
        public string IsCreditTaken { get; set; }
        public string StatusId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
