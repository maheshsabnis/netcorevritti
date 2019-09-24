using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AuditParticipants
    {
        public string AuditParticipantId { get; set; }
        public string AuditPlanId { get; set; }
        public string UserMasterId { get; set; }
        public string IsAuditee { get; set; }
    }
}
