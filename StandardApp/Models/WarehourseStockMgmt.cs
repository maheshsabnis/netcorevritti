using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WarehourseStockMgmt
    {
        public string WhstockMgmtId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string ItemPlantId { get; set; }
        public string PlantId { get; set; }
        public decimal? MinimumStock { get; set; }
        public decimal? MaximumStock { get; set; }
        public string RecorderLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string UserLevel { get; set; }
        public string CreationLevel { get; set; }
    }
}
