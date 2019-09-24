using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrpplan
    {
        public string MrpplanId { get; set; }
        public string BatchNo { get; set; }
        public string ItemPlantId { get; set; }
        public DateTime? MrpplanDate { get; set; }
        public decimal? PlanQty { get; set; }
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
        public string MrpprojectionId { get; set; }
        public DateTime? PlanRecDate { get; set; }
        public DateTime? ReleaseDt { get; set; }
    }
}
