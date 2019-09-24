using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrpprojection
    {
        public string MrpprojectionId { get; set; }
        public string BatchNo { get; set; }
        public string ItemPlantId { get; set; }
        public DateTime? MrpprojDate { get; set; }
        public decimal? Receipt { get; set; }
        public decimal? Cons { get; set; }
        public decimal? ProjBal { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? RecCons { get; set; }
        public decimal? DelayedRecDays { get; set; }
        public decimal? TotalShipgLeadTime { get; set; }
        public string MrpplanId { get; set; }
        public string SrcDocNo { get; set; }
        public string AddSrcDocNo { get; set; }
        public string Action { get; set; }
        public DateTime? OrgScheduleDt { get; set; }
        public string DocType { get; set; }
        public decimal? ProjSeqNo { get; set; }
    }
}
