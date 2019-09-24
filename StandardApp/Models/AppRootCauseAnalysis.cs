using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AppRootCauseAnalysis
    {
        public string RootCauseId { get; set; }
        public string ActivityId { get; set; }
        public string RootCause { get; set; }
        public string Solution { get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Isdeleted { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? Userlevel { get; set; }
        public string SyncInfo { get; set; }
    }
}
