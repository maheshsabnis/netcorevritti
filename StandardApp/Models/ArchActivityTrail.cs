using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ArchActivityTrail
    {
        public string ArchiveTrailId { get; set; }
        public string ArchiveHistoryId { get; set; }
        public string ActivityTrailId { get; set; }
        public string ActivityId { get; set; }
        public decimal? AssignedCount { get; set; }
        public string ForUserMasterId { get; set; }
        public string Action { get; set; }
        public string Narration { get; set; }
        public decimal? Status { get; set; }
        public string PrecedingActivityTrailId { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
        public decimal? PreActivityStatus { get; set; }
        public decimal? NxtActivityStatus { get; set; }
        public string SourceType { get; set; }
    }
}
