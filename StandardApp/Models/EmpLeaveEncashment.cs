using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmpLeaveEncashment
    {
        public string EmpLeaveEncashmentId { get; set; }
        public string LeaveEnchNo { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? LeaveEncashDt { get; set; }
        public string YearId { get; set; }
        public string LeaveType { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public decimal? LeaveCount { get; set; }
        public int? CurYearDays { get; set; }
        public int? NxtYearDays { get; set; }
        public string LeaveMethod { get; set; }
        public string Status { get; set; }
        public string CancelStatus { get; set; }
        public string LeaveSource { get; set; }
        public string ApprovedById { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public string Fkmlid { get; set; }
        public string Reason { get; set; }
        public string CreationLevel { get; set; }
        public string UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
