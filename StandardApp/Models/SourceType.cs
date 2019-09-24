using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SourceType
    {
        public string SourceTypeId { get; set; }
        public string SourceType1 { get; set; }
        public string Status { get; set; }
        public string NoofDays { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string IsDeleted { get; set; }
        public string ActivityTypeId { get; set; }
        public string SourceTypeDesc { get; set; }
        public string ProjectId { get; set; }
    }
}
