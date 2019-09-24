using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProinputItemDetail
    {
        public string ProinputItemDetailId { get; set; }
        public string ProoutputItemDetailId { get; set; }
        public string PoheaderId { get; set; }
        public string PlantMasterId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public string UommasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? QtyReceived { get; set; }
        public string LineStatus { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
