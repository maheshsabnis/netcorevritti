using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCommonWordMaster
    {
        public string PkwordId { get; set; }
        public string WordDesc { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
