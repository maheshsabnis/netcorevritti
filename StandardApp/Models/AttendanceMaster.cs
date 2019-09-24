using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AttendanceMaster
    {
        public string PkattendanceId { get; set; }
        public string FkemployeeId { get; set; }
        public DateTime? Date { get; set; }
        public string AttendanceCode { get; set; }
        public bool? IsApproved { get; set; }
        public string Remarks { get; set; }
        public bool? IsAutomated { get; set; }
        public decimal PresentDay { get; set; }
        public decimal? AbsentDay { get; set; }
        public decimal? LeaveDay { get; set; }
        public string LeaveCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public int? OtMin { get; set; }
        public decimal? OtMinoffDay { get; set; }
    }
}
