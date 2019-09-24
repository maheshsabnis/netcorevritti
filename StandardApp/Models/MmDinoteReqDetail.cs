using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmDinoteReqDetail
    {
        public string DinoteDetailId { get; set; }
        public string DinoteReqHeaderId { get; set; }
        public string ContractDetailId { get; set; }
        public string DinoteNo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
