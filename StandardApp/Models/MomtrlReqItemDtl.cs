using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MomtrlReqItemDtl
    {
        public string MomtrlReqItemDtlId { get; set; }
        public string MomtrlReqHeaderId { get; set; }
        public string MomtrlReqDtlId { get; set; }
        public string ModetailId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ReqQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
