using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class NarrationMaster
    {
        public decimal RecId { get; set; }
        public string NarrationMasterId { get; set; }
        public string Description { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
