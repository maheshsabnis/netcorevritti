using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BranchMaster
    {
        public string PkbranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Quota { get; set; }
        public decimal? Equota { get; set; }
        public decimal? TotalEmployee { get; set; }
        public decimal? MinEmpRequired { get; set; }
        public decimal? MinConductorReq { get; set; }
        public decimal? MinDriverReq { get; set; }
        public decimal? MinDriCumConduReq { get; set; }
        public string FkparentBranch { get; set; }
        public decimal? InstallationId { get; set; }
        public decimal? LongLeavQuata { get; set; }
        public string FkPlantMasterId { get; set; }
    }
}
