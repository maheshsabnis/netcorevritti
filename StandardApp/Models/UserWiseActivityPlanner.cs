using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserWiseActivityPlanner
    {
        public Guid RecordId { get; set; }
        public string UserMasterId { get; set; }
        public string UserLoginId { get; set; }
        public string UserName { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string LocationName { get; set; }
        public string IsLeaveTaken { get; set; }
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ProjectName { get; set; }
        public string ActivityAssignmentRemark { get; set; }
    }
}
