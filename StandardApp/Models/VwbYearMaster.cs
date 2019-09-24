using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VwbYearMaster
    {
        public string PkyearId { get; set; }
        public string YearCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsCurrentYear { get; set; }
        public string IsPreviousYear { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
