using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SubContractWip
    {
        public string SubContractWipid { get; set; }
        public string MoHeaderId { get; set; }
        public string LabourChargeId { get; set; }
        public string FromwipitemId { get; set; }
        public string TowipitemId { get; set; }
        public bool? MoveToWip { get; set; }
        public decimal? OutRatio { get; set; }
        public decimal? InRatio { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string MoroutingId { get; set; }
        public string FrmOperationId { get; set; }
        public string ToOperationId { get; set; }
    }
}
