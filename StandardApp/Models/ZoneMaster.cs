using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ZoneMaster
    {
        public string ZoneMasterId { get; set; }
        public string ZoneCode { get; set; }
        public string ZoneDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
