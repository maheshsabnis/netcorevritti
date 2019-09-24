using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmailAlert
    {
        public string EmailAlertId { get; set; }
        public string UserMasterId { get; set; }
        public string MessageText { get; set; }
        public DateTime? SentTime { get; set; }
        public string LastDate { get; set; }
    }
}
