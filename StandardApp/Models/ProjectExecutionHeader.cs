using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectExecutionHeader
    {
        public string ProjectExecutionHeaderId { get; set; }
        public string ProjectExecutionDate { get; set; }
        public string ItemMasterId { get; set; }
        public string WorkOrderId { get; set; }
        public string SectionFrom { get; set; }
        public string SectionTo { get; set; }
        public string ProjectActivitiesId { get; set; }
        public string Lenght { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
