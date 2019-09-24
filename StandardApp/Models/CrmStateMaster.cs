using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmStateMaster
    {
        public string PkstateId { get; set; }
        public string StateNo { get; set; }
        public string StateDesc { get; set; }
        public string FkcountryId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string StateCodeNo { get; set; }
    }
}
