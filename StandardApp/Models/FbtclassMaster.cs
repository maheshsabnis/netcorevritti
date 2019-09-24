using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class FbtclassMaster
    {
        public decimal RecId { get; set; }
        public string FbtclassMasterId { get; set; }
        public string FinDivId { get; set; }
        public string Fbtcode { get; set; }
        public string Fbtdesc { get; set; }
        public string IsActive { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
