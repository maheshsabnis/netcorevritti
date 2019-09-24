using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TimeReqdMaster
    {
        public string TimeReqdMasterId { get; set; }
        public string TimeReqd { get; set; }
        public string TimeRequiredPer { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string Modifiedy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
