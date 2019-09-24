using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemLocType
    {
        public string ItemLocTypeId { get; set; }
        public string ItemPlantId { get; set; }
        public string LocationTypeId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Weight { get; set; }
        public decimal? Lbhlength { get; set; }
        public decimal? Lbhbreadth { get; set; }
        public decimal? Lbhheight { get; set; }
    }
}
