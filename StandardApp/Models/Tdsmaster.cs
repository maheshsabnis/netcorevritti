using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Tdsmaster
    {
        public decimal RecId { get; set; }
        public string TdsmasterId { get; set; }
        public string TdsclassMasterId { get; set; }
        public string FinDivId { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffTo { get; set; }
        public decimal? Tdsper { get; set; }
        public decimal? Surcharge { get; set; }
        public decimal? EducationCess { get; set; }
        public string Section { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
