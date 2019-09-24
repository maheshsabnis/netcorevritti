using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MemberClassificationMaster
    {
        public string ClassificationId { get; set; }
        public string ClassificationType { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
