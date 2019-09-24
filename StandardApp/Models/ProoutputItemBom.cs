using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProoutputItemBom
    {
        public string ProoutputItemBomid { get; set; }
        public string ProoutputItemDetailId { get; set; }
        public string BomdetailId { get; set; }
        public decimal? QtyReqd { get; set; }
        public decimal? QtyPer { get; set; }
        public decimal? TotalIssue { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
