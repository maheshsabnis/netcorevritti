using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CshDenomEntry
    {
        public decimal RecId { get; set; }
        public string FinDivId { get; set; }
        public string CshDenomEntryId { get; set; }
        public string TransCashLineId { get; set; }
        public string LineSource { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? Rs1000 { get; set; }
        public decimal? Rs500 { get; set; }
        public decimal? Rs100 { get; set; }
        public decimal? Rs50 { get; set; }
        public decimal? Rs20 { get; set; }
        public decimal? Rs10 { get; set; }
        public decimal? Rs5 { get; set; }
        public decimal? Rs2 { get; set; }
        public decimal? Rs1 { get; set; }
        public decimal? Coins { get; set; }
        public decimal? TotalAmt { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
