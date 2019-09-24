using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCallStatusMaster
    {
        public string PkcallStatusId { get; set; }
        public string CallStatusCode { get; set; }
        public string CallStatus { get; set; }
        public string CallStatusDesc { get; set; }
        public string CallStatusColorCode { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
