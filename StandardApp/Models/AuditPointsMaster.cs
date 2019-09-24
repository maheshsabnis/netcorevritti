using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuditPointsMaster
    {
        public string AuditPointId { get; set; }
        public string AuditPointDesc { get; set; }
        public string AuditProcessId { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
