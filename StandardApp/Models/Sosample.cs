using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Sosample
    {
        public string SosampleId { get; set; }
        public string SodetailId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? SampleQty { get; set; }
        public DateTime? SampleShceduleDt { get; set; }
        public DateTime? SampleSubmisionDt { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
