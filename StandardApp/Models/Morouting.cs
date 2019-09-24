using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Morouting
    {
        public string MoroutingId { get; set; }
        public string ItemRoutingId { get; set; }
        public string MoheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public string RoutingSeq { get; set; }
        public decimal? TimeReqd { get; set; }
        public decimal? TimeReqdCode { get; set; }
        public decimal? SetupHrs { get; set; }
        public decimal? SetupCrewSize { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? NextStageQty { get; set; }
        public string WipitemId { get; set; }
        public string OperationSeqId { get; set; }
        public decimal? IssuedQty { get; set; }
        public decimal? Moqty { get; set; }
        public DateTime? StartDt { get; set; }
        public DateTime? EndDt { get; set; }
        public decimal? ReqMcn { get; set; }
        public decimal? AllocMcn { get; set; }
        public decimal? Srt { get; set; }
        public decimal? Art { get; set; }
        public string MachineGroupMasterId { get; set; }
        public decimal? ReworkQty { get; set; }
        public decimal? SecondsQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? StdWt { get; set; }
        public decimal? PercentEfficiency { get; set; }
        public string StatusId { get; set; }
        public decimal? TransferQty { get; set; }
        public decimal? QtyToProd { get; set; }
        public DateTime? ExpectedEndDt { get; set; }
        public decimal? PerDayOutput { get; set; }
        public DateTime? ActualStartDt { get; set; }
        public DateTime? ActualEndDt { get; set; }
        public decimal? OffsetDays { get; set; }
        public decimal? QlpendingQty { get; set; }
        public decimal? TinShedPickedQty { get; set; }
        public decimal? TimeUnitForSetup { get; set; }
        public decimal? StdOperationYield { get; set; }
        public decimal? StdCummulativeYield { get; set; }
        public decimal? NoOfMcnGrp { get; set; }
        public decimal? NoOfLabour { get; set; }
        public decimal? TimeReqdForrMcnGrp { get; set; }
        public decimal? TimeReqdForLabour { get; set; }
        public decimal? TimeUnitForLabour { get; set; }
        public decimal? ItemQty { get; set; }
        public decimal? TimeUnitForMcnGrp { get; set; }
    }
}
