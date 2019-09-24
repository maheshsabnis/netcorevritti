using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AttandanceApprovalLog
    {
        public string PkattendanceApprovalLogId { get; set; }
        public string FkAttendanceMasterId { get; set; }
        public string AttendanceCode { get; set; }
        public bool ApprovalStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime AddedDt { get; set; }
        public string AddedBy { get; set; }
    }
}
