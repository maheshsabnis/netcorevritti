using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Grncharges
    {
        public string GrnchargeId { get; set; }
        public string GrnheaderId { get; set; }
        public string ChargeMasterId { get; set; }
        public decimal? Amt { get; set; }
        public decimal? Per { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
