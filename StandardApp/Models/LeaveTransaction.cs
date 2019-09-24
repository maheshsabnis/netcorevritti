using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LeaveTransaction
    {
        public string PkleaveTransId { get; set; }
        public string FkUserId { get; set; }
        public string LeaveCode { get; set; }
        public string YearCode { get; set; }
        public string BalanceType { get; set; }
        public decimal? NoOfDays { get; set; }
        public string Remark { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AddedMethodType { get; set; }
        public string BatchCode { get; set; }
        public string CurrentStatus { get; set; }
        public string Uploadmethod { get; set; }
    }
}
