using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuditPlanMaster
    {
        public string AuditPlanId { get; set; }
        public string AuditProcessId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
