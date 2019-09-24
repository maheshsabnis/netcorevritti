using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WorkFlowStgActivity
    {
        public string WorkFlwStgActId { get; set; }
        public string ActivityId { get; set; }
        public string WorkflowStageId { get; set; }
        public string UnitId { get; set; }
        public int? OffsetTime { get; set; }
    }
}
