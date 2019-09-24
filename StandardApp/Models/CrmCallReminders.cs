using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallReminders
    {
        public string PkReminderId { get; set; }
        public string CallId { get; set; }
        public string ExecutiveId { get; set; }
        public string ReminderType { get; set; }
        public DateTime? DateTime { get; set; }
        public string Notes { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
