using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslSchedulerReportDefinitions
    {
        public string ScheduleId { get; set; }
        public decimal ScheduleNo { get; set; }
        public string RptXml { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string RptName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
