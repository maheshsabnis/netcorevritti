using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StateMaster
    {
        public string StateMasterId { get; set; }
        public string StateCode { get; set; }
        public string StateDesc { get; set; }
        public string TaxClassMasterId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
