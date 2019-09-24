using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ActivityPlanner
    {
        public Guid RecordId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? ActivityDate { get; set; }
        public string ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime? ActivityStartDate { get; set; }
        public DateTime? ActivityEndDate { get; set; }
        public string IssuedTo { get; set; }
        public string UserName { get; set; }
        public string DateRemark { get; set; }
        public string AssignTo { get; set; }
        public string PassCode { get; set; }
        public string LocationName { get; set; }
    }
}
