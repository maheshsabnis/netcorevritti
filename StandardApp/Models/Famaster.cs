using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Famaster
    {
        public decimal? RecId { get; set; }
        public string FinDivId { get; set; }
        public string FamstId { get; set; }
        public string Code { get; set; }
        public string AssetType { get; set; }
        public string AcMastId { get; set; }
        public decimal? OpBal { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
