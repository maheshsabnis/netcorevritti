using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCompetitorMaster
    {
        public string PkcompetitorId { get; set; }
        public string CompetitorName { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string ContactNo { get; set; }
        public string Realations { get; set; }
        public string MarketPosition { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
