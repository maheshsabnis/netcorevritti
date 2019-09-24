using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Uommaster
    {
        public string UommasterId { get; set; }
        public string Uomcode { get; set; }
        public string Uomdesc { get; set; }
        public int? Uomdigit { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
