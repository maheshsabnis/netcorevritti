using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ApportionmentMaster
    {
        public decimal RecId { get; set; }
        public string ApportionmentMasterId { get; set; }
        public string ApportionmentClassId { get; set; }
        public string FinDivId { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffTo { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
