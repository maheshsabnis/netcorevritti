using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Locentry
    {
        public decimal RecId { get; set; }
        public string LocentryId { get; set; }
        public string FinDivId { get; set; }
        public string SupplierId { get; set; }
        public string Lcno { get; set; }
        public DateTime Lcdate { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public decimal? Lcamt { get; set; }
        public decimal? LcamtUtilized { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
