using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WorkflowStage
    {
        public string WorkflowStageId { get; set; }
        public string SeqNo { get; set; }
        public string WorkflowId { get; set; }
        public string WorkflowStageDesc { get; set; }
        public decimal? OffsetInDays { get; set; }
        public decimal? OffsetInHours { get; set; }
        public decimal? EstimatedHours { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ActivityTypeId { get; set; }
        public string UserMasterId { get; set; }
        public string PrecedingStageId { get; set; }
        public decimal? CompletionWithin { get; set; }
    }
}
