using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MomtrlReqHeader
    {
        public string MomtrlReqHeaderId { get; set; }
        public string MomtrlReqNo { get; set; }
        public DateTime? MomtrlReqDt { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string ReqType { get; set; }
        public string StatusId { get; set; }
    }
}
