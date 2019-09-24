using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AttendanceCodeMaster
    {
        public string PkattendanceCodeMasterId { get; set; }
        public string AttendanceCodeValue { get; set; }
        public string AttendanceCodeDesc { get; set; }
        public string IsPresentInAttendanceApproval { get; set; }
        public string IsPresentInUserManagement { get; set; }
    }
}
