using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmReasonMaster
    {
        public string PkreasonId { get; set; }
        public string FkreasonCategoryId { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
