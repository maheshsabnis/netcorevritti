using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ArchiveHistory
    {
        public string ArchiveHistoryId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Count { get; set; }
        public string HistoryStatus { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
