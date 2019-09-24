using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaxClassMaster
    {
        public string TaxClassMasterId { get; set; }
        public string TaxClassCode { get; set; }
        public string TaxClassDesc { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveUpto { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsActive { get; set; }
        public string Module { get; set; }
    }
}
