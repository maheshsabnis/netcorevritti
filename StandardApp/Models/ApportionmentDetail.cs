using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ApportionmentDetail
    {
        public decimal RecId { get; set; }
        public string ApportionmentDetailId { get; set; }
        public string ApportionmentMasterId { get; set; }
        public string CostCentreId { get; set; }
        public decimal? Percentage { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
