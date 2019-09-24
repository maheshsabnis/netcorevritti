using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Cstinfo
    {
        public string RecId { get; set; }
        public string CstinfoId { get; set; }
        public string VoucherNo { get; set; }
        public string FormType { get; set; }
        public string FormNumber { get; set; }
        public DateTime? FormDt { get; set; }
        public string SerialNo { get; set; }
        public string ClaimStatus { get; set; }
        public string ClaimNumber { get; set; }
        public string Remark { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PaidStatus { get; set; }
        public decimal? VouAmt { get; set; }
        public decimal? PaidAmt { get; set; }
    }
}
