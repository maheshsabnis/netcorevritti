using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TrnwiseDocAppr
    {
        public string DocApprId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentId { get; set; }
        public string Requestor { get; set; }
        public DateTime? ReqDt { get; set; }
        public int? ApprLineNo { get; set; }
        public string Approver { get; set; }
        public string ApprStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? ApprDt { get; set; }
    }
}
