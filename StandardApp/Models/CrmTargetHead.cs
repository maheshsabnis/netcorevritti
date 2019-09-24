using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTargetHead
    {
        public string PktargetHeadId { get; set; }
        public string TargetCode { get; set; }
        public string TargetDesc { get; set; }
        public string TargetInUnit { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string DefinedForId { get; set; }
        public string DefinedForText { get; set; }
        public int? CalculateMethod { get; set; }
        public int? PeriodLength { get; set; }
    }
}
