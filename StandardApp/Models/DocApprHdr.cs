using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DocApprHdr
    {
        public string DocApprHdrId { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string DocApprMthdId { get; set; }
        public decimal? DocValue { get; set; }
        public string CurrentApprLvl { get; set; }
        public string FinalApprLvl { get; set; }
        public string StatusId { get; set; }
        public string LatestDltId { get; set; }
        public string IsDeleted { get; set; }
        public decimal? UserLevel { get; set; }
        public decimal? CreationLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Reason { get; set; }
        public string FilePath { get; set; }
        public string Url { get; set; }
        public string DocNo { get; set; }
    }
}
