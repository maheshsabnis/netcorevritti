using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransAppntLines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransGllinesId { get; set; }
        public string TransAppntLineId { get; set; }
        public string FinDivId { get; set; }
        public string CostCentreId { get; set; }
        public decimal? LineVal { get; set; }
        public decimal? LineValFc { get; set; }
        public string LineNarrative { get; set; }
        public string LineFinDivId { get; set; }
        public string LinePeriodDisSeq { get; set; }
        public string LineCurrency { get; set; }
        public string LineSource { get; set; }
        public string NarrativeId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Percentage { get; set; }
    }
}
