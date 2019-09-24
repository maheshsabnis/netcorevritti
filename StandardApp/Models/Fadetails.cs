using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Fadetails
    {
        public decimal? RecId { get; set; }
        public string FinDivId { get; set; }
        public string FadtlId { get; set; }
        public string FamstId { get; set; }
        public string MethodOn { get; set; }
        public string CalcMthd { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Amount { get; set; }
        public string IsWip { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
