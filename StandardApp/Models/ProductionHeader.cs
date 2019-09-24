using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProductionHeader
    {
        public string ProductionHeaderId { get; set; }
        public string ProdNo { get; set; }
        public DateTime? ProdDt { get; set; }
        public string ShiftId { get; set; }
        public string EnterBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
    }
}
