using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserLeaveSetting
    {
        public string LeaveSettingId { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
        public decimal? ClSl { get; set; }
        public decimal? Pl { get; set; }
        public decimal? BalanceClSl { get; set; }
        public decimal? BalancePl { get; set; }
        public decimal? Lwp { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
