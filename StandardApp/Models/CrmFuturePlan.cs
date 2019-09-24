using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmFuturePlan
    {
        public string PkfuturePlanId { get; set; }
        public string FksuspectId { get; set; }
        public string FkcallId { get; set; }
        public string NextAction { get; set; }
        public DateTime NextDate { get; set; }
        public string ExecutiveId { get; set; }
        public string Notes { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
