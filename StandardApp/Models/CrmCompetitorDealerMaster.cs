using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCompetitorDealerMaster
    {
        public string PkcompetitorDealerId { get; set; }
        public string DealerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
