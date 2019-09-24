using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LeaveTypeMaster
    {
        public string LeaveTypeId { get; set; }
        public string LeaveDescription { get; set; }
        public string IsDeleted { get; set; }
        public string LeaveCode { get; set; }
        public bool? CheckBalance { get; set; }
        public decimal? MaxDaysInOneOccur { get; set; }
        public decimal? MaxDaysInOnePeriod { get; set; }
        public decimal? MaxOccurInOnePeriod { get; set; }
        public decimal? MaxOccurInOneYear { get; set; }
        public bool? AllowLeaveCarryForwrd { get; set; }
        public decimal? MaxDaysCarryFrwrd { get; set; }
        public bool? IsExtraWork { get; set; }
        public bool? CountWeeklyOffForLeave { get; set; }
        public bool? CountHolidaysForLeave { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsEncashmentApplicable { get; set; }
        public bool? ConsiderAbsnInAttendance { get; set; }
    }
}
