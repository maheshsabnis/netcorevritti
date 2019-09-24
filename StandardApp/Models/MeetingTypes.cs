using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MeetingTypes
    {
        public string MeetingTypeId { get; set; }
        public string MeetingTypeDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
