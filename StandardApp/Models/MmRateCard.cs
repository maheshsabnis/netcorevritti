using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmRateCard
    {
        public string RateCardId { get; set; }
        public string RateCardHeaderId { get; set; }
        public string LocationRateCategoryId { get; set; }
        public string PositionCategoryId { get; set; }
        public string MediaTypeId { get; set; }
        public decimal? Rate { get; set; }
        public string Uomid { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
