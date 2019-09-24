using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemRoutingDetail
    {
        public string ItemRoutingDetailId { get; set; }
        public string ItemRoutingHeaderId { get; set; }
        public string RoutingSeq { get; set; }
        public string MachineGroupId { get; set; }
        public string OperationDesc { get; set; }
        public decimal? TimeReqd { get; set; }
        public string TimeReqdCode { get; set; }
        public decimal? SetupHrs { get; set; }
        public decimal? SetupCrewSize { get; set; }
        public decimal? StdRunFixedCost { get; set; }
        public decimal? FutureRunFixedCost { get; set; }
        public decimal? StdRunVariableCost { get; set; }
        public decimal? FutureRunVariableCost { get; set; }
        public decimal? StdRunLabourCost { get; set; }
        public decimal? FutureRunLabourCost { get; set; }
        public decimal? StdSetupFixedCost { get; set; }
        public decimal? FutureSetupFixedCost { get; set; }
        public decimal? StdOperationYield { get; set; }
        public decimal? FutureOperationYield { get; set; }
        public decimal? StdCummulativeYield { get; set; }
        public decimal? FutureCummulativeYield { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? NoOfMcnGrp { get; set; }
        public decimal? NoOfLabour { get; set; }
        public decimal? TimeReqdForrMcnGrp { get; set; }
        public decimal? TimeReqdForLabour { get; set; }
        public decimal? TimeUnitForMcnGrp { get; set; }
        public decimal? TimeUnitForLablor { get; set; }
        public decimal? ItemQty { get; set; }
        public string OperationSeqId { get; set; }
        public string WipitemId { get; set; }
        public decimal? StdWt { get; set; }
        public string OperationDetail { get; set; }
    }
}
