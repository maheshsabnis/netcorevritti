using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ViRequestLogMaster
    {
        public string RequestId { get; set; }
        public DateTime? ReqDt { get; set; }
        public string ReqDesc { get; set; }
        public string ProjectId { get; set; }
        public decimal? ReqTypeId { get; set; }
        public string InitiatedBy { get; set; }
        public string Remarks { get; set; }
        public string IsApproved { get; set; }
        public string IsAssigned { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
