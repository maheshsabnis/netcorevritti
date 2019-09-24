using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Fbtmaster
    {
        public decimal RecId { get; set; }
        public string FbtmasterId { get; set; }
        public string FbtclassMasterId { get; set; }
        public string FinDivId { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffTo { get; set; }
        public decimal? Fbper { get; set; }
        public decimal? Fbtper { get; set; }
        public decimal? Surcharge { get; set; }
        public decimal? EducationCess { get; set; }
        public decimal? Hsecess { get; set; }
        public string UnderSection { get; set; }
        public string IsActive { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
