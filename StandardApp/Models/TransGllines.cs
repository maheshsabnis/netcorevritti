using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransGllines
    {
        public decimal RecId { get; set; }
        public string TransHeaderId { get; set; }
        public string TransGllinesId { get; set; }
        public string FinDivId { get; set; }
        public string GllineNo { get; set; }
        public string LineSourceType { get; set; }
        public string LineSourceId { get; set; }
        public decimal? LineVal { get; set; }
        public decimal? LineValFc { get; set; }
        public string LineNarrative { get; set; }
        public string LineFinDivId { get; set; }
        public string LineUnit { get; set; }
        public string LineAccountId { get; set; }
        public string LinePeriodId { get; set; }
        public decimal? LinePeriodDisSeq { get; set; }
        public string LineCurrency { get; set; }
        public string LineApportionmentId { get; set; }
        public string LineAccType { get; set; }
        public string LineAccPeriodId { get; set; }
        public string AccuralRevStatus { get; set; }
        public string LineSource { get; set; }
        public string LineStatus { get; set; }
        public string NarrativeId { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
