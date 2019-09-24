using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AccessHistory
    {
        public decimal RecId { get; set; }
        public string AccessHistoryId { get; set; }
        public string ModuleName { get; set; }
        public string TaskName { get; set; }
        public string UserId { get; set; }
        public DateTime? AccessDt { get; set; }
        public string Remarks { get; set; }
    }
}
