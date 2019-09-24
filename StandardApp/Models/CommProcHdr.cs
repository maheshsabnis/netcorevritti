using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommProcHdr
    {
        public string CommProcHdrId { get; set; }
        public string CommTypeId { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string CommNo { get; set; }
        public string CommApprover { get; set; }
        public string SecondApprover { get; set; }
    }
}
