using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectAllocation
    {
        public string ProjectAllocationId { get; set; }
        public string ProjectId { get; set; }
        public string UserId { get; set; }
        public DateTime? InvolvmentDt { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
