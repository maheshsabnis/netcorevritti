using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class FwdCoverEntry
    {
        public decimal RecId { get; set; }
        public string FwdCoverEntryId { get; set; }
        public string FinDivId { get; set; }
        public string FwdCoverNo { get; set; }
        public string FwdCoverNoUe { get; set; }
        public DateTime? FwdCoverDate { get; set; }
        public DateTime? EffFrom { get; set; }
        public DateTime? EffTo { get; set; }
        public decimal? ForeignAmt { get; set; }
        public decimal? SpotRate { get; set; }
        public decimal? FwdRate { get; set; }
        public decimal? Inramount { get; set; }
        public decimal? FwdCoverUtilized { get; set; }
        public decimal? FwdCoverCancelled { get; set; }
        public string CurrencyMasterId { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
