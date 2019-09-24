using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MachineGroupMaster
    {
        public string MachineGroupMasterId { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public decimal? NoOfMachines { get; set; }
        public decimal? StdFixedOverheadRate { get; set; }
        public decimal? FutureFixedOverheadRate { get; set; }
        public decimal? StdVariableOverheadRate { get; set; }
        public decimal? FutureVariableOverheadRate { get; set; }
        public decimal? StdLabourRate { get; set; }
        public decimal? FutureLabourRate { get; set; }
        public decimal? StdOtherOverheadRate1 { get; set; }
        public decimal? FutureOtherOverheadRate1 { get; set; }
        public decimal? StdOtherOverheadRate2 { get; set; }
        public decimal? FutureOtherOverheadRate2 { get; set; }
        public bool? Osp { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string Modifiedy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string DeptMasterId { get; set; }
        public string OperationMasterId { get; set; }
        public string CalendarId { get; set; }
        public decimal? MaxCapacity { get; set; }
        public decimal? MinCapacity { get; set; }
        public string MachineGrpClr { get; set; }
        public string OrderTypeMasterId { get; set; }
        public decimal? AvgMaxHours { get; set; }
    }
}
