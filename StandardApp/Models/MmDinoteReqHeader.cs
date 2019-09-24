using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmDinoteReqHeader
    {
        public string DinoteReqHeaderId { get; set; }
        public string DinoteReqNumber { get; set; }
        public DateTime? DireqFromDt { get; set; }
        public DateTime? DireqToDt { get; set; }
        public string DireqHeaderRemark { get; set; }
        public string CustomerId { get; set; }
        public string PrintingStatus { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string AdvProdName { get; set; }
    }
}
