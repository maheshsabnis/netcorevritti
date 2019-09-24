using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DefectLoggingActivity
    {
        public string PkdefectId { get; set; }
        public string DefectId { get; set; }
        public string DefectDescription { get; set; }
        public string DefectEnvironment { get; set; }
        public string PriorityId { get; set; }
        public string Severity { get; set; }
        public string StepsReproduce { get; set; }
        public string DefectStatus { get; set; }
        public string TesterId { get; set; }
        public decimal? CauseOfDefect { get; set; }
        public string ProjectId { get; set; }
        public string ModuleId { get; set; }
        public string IsDeleted { get; set; }
        public decimal? DefNo { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string TestId { get; set; }
        public string ActivityId { get; set; }
        public string UsermasterId { get; set; }
    }
}
