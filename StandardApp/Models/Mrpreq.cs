using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrpreq
    {
        public string MrpreqId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? MrpreqDate { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ReqQtyinStkUnit { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Source { get; set; }
        public string SourceId { get; set; }
    }
}
