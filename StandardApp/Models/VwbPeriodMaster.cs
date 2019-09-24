using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VwbPeriodMaster
    {
        public string PkperiodMasterId { get; set; }
        public string PeriodSeq { get; set; }
        public string FkyearId { get; set; }
        public string PeriodCode { get; set; }
        public DateTime? Prsdate { get; set; }
        public DateTime? Predate { get; set; }
        public string Prtype { get; set; }
        public string SecId { get; set; }
        public bool? IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? PeriodLength { get; set; }
    }
}
