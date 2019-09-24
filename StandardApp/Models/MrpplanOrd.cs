using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MrpplanOrd
    {
        public string MrpplanOrdId { get; set; }
        public string BatchNo { get; set; }
        public string ItemPlantId { get; set; }
        public DateTime? MrpplanOrdDate { get; set; }
        public decimal? PlanOrdQty { get; set; }
        public bool? MfgPur { get; set; }
        public string MoPo { get; set; }
        public bool? MrpprojAddStatus { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EarliestRecDate { get; set; }
        public decimal? LeadTime { get; set; }
        public string VendorId { get; set; }
        public string MrpplanId { get; set; }
        public decimal? MultiplesQty { get; set; }
        public decimal? Eoq { get; set; }
    }
}
