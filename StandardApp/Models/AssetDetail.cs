using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AssetDetail
    {
        public string AssetDetailId { get; set; }
        public string AssetHeaderId { get; set; }
        public string AssetNo { get; set; }
        public string LocationMasterId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public string LocationDesc { get; set; }
        public decimal? AcquisitionValue { get; set; }
        public decimal? DepreciationValue { get; set; }
        public decimal? ReturnedValue { get; set; }
    }
}
