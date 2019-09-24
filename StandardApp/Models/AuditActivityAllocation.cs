using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuditActivityAllocation
    {
        public string AuditActAllocId { get; set; }
        public string AuditPlanId { get; set; }
        public string AuditFindingId { get; set; }
        public string ActivityAllocMstId { get; set; }
    }
}
