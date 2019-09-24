using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PlantWareHouseMaster
    {
        public string PlantWareHouseMasterId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseDescription { get; set; }
        public string PlantId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string Modifiedy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
