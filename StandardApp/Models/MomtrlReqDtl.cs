using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MomtrlReqDtl
    {
        public string MomtrlReqDtlId { get; set; }
        public string MomtrlReqHeaderId { get; set; }
        public string MoheaderId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ReqForQty { get; set; }
        public decimal? ReqForQtyWithYield { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
