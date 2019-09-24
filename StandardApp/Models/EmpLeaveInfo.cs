using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmpLeaveInfo
    {
        public string ApplicationId { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? LeaveFromDate { get; set; }
        public DateTime? LeaveToDate { get; set; }
        public string Reason { get; set; }
        public string LeaveType { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Approved { get; set; }
        public string IsDeleted { get; set; }
    }
}
