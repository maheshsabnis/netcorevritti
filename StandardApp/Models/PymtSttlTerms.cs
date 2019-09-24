using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PymtSttlTerms
    {
        public decimal RecId { get; set; }
        public string PymtSttlTermsId { get; set; }
        public string PymtSettTermMasterId { get; set; }
        public string FinDivId { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffUpto { get; set; }
        public string ApplyIntCalc { get; set; }
        public decimal? IntRate { get; set; }
        public decimal? GracePeriod { get; set; }
        public string IntCalcMethod { get; set; }
        public decimal? IntPeriod { get; set; }
        public string ChargeId { get; set; }
        public string BaseDate { get; set; }
        public decimal? PenaltyAmt { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? PymtSettPer { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
