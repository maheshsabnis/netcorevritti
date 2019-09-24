using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AlertHistory
    {
        public string PkAlertHistoryId { get; set; }
        public string DeviceId { get; set; }
        public string Message { get; set; }
        public string ServerApiKey { get; set; }
        public string SenderId { get; set; }
        public string UserName { get; set; }
        public DateTime? Addeddate { get; set; }
        public string Status { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
    }
}
