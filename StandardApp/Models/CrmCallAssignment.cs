using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallAssignment
    {
        public string PkcallAssignId { get; set; }
        public string FksuspectId { get; set; }
        public string FkcallStatusId { get; set; }
        public string FkissuedToId { get; set; }
        public string Comments { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public DateTime? ScheduledTime { get; set; }
        public string IsDemoRequired { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
