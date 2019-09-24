using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SupportTktReopen
    {
        public string PktktReOpenId { get; set; }
        public string UserMasterId { get; set; }
        public string ActivityId { get; set; }
        public string ReopenReason { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
        public DateTime? ActCompletionDate { get; set; }
    }
}
