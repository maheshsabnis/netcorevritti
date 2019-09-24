using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MrpplanStatus
    {
        public string ItemPlantId { get; set; }
        public bool? PlanStatus { get; set; }
        public decimal? RecurCount { get; set; }
        public decimal? DefaultAddstatus { get; set; }
    }
}
