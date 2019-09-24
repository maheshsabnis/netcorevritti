using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProblemCategoryMaster
    {
        public string PkproblemCategoryMaster { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string ResolutionTime { get; set; }
        public string Priority { get; set; }
        public string ResolutionTimeDays { get; set; }
        public string CalcEfforts { get; set; }
        public string IsWeeklyOff { get; set; }
        public string IsHrs { get; set; }
        public string IsHoliday { get; set; }
        public string ToTime { get; set; }
        public string FromTime { get; set; }
    }
}
