using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostCentreMaster
    {
        public decimal RecId { get; set; }
        public string CostCtrMasterId { get; set; }
        public string CostCtrCode { get; set; }
        public string CostCtrDesc { get; set; }
        public bool Proportionate { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
