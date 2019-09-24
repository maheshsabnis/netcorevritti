using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTravelPlan
    {
        public string PktravelPlanId { get; set; }
        public string ExecutiveId { get; set; }
        public DateTime? Date { get; set; }
        public string CityId { get; set; }
        public string Notes { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLeave { get; set; }
        public string Time { get; set; }
    }
}
