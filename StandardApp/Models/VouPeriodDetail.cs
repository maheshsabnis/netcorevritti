using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VouPeriodDetail
    {
        public decimal RecId { get; set; }
        public string VouPeriodDetailId { get; set; }
        public string PeriodMasterId { get; set; }
        public string VouMasterId { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
