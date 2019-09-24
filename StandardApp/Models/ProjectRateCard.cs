using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectRateCard
    {
        public string ProjRateCardId { get; set; }
        public string ProjectId { get; set; }
        public string ParticipantId { get; set; }
        public string ProjectTypeId { get; set; }
        public decimal? Rate { get; set; }
        public string RateBasis { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
