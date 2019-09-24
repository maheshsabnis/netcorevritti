using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqtQuotationDtlMedia
    {
        public string BqtQuotationDtlMediaId { get; set; }
        public string BqtQuotationDtlId { get; set; }
        public string BqtQuotationHeaderId { get; set; }
        public int NoOfPack { get; set; }
        public int Duration { get; set; }
        public string DurationUnit { get; set; }
        public string Repetations { get; set; }
        public decimal? OfferedRate { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? JingleLength { get; set; }
        public string NoOfJingles { get; set; }
        public string ReleaseStdStartTime { get; set; }
        public string ReleaseStdEndTime { get; set; }
        public string ReleaseCustStartTime { get; set; }
        public string ReleaseCustEndTime { get; set; }
        public decimal? RepetitionsEveryMinutes { get; set; }
        public int SpotsChargeble { get; set; }
        public int SpotsFree { get; set; }
        public decimal? TotalRepetitionsForSelectedLoc { get; set; }
        public decimal? TotalRepetitionsForSelectedLocForCamp { get; set; }
        public decimal TotalPkgCost { get; set; }
        public decimal FtotalPkgCost { get; set; }
        public decimal FinalPkgCostMonth { get; set; }
        public decimal FfinalPkgCostMonth { get; set; }
        public decimal FinalPkgCostForDuration { get; set; }
        public decimal FfinalPkgCostForDuration { get; set; }
        public string SpecialComments { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
