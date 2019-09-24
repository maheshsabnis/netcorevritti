using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaxSetOffEntryMaster
    {
        public decimal RecId { get; set; }
        public string FinDivId { get; set; }
        public string TaxSetOffInfoId { get; set; }
        public string SetOffCode { get; set; }
        public DateTime? ValidFromDt { get; set; }
        public DateTime? ValidToDt { get; set; }
        public string RecdGlid { get; set; }
        public string PayableGlid { get; set; }
        public decimal? SetOffPer { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
