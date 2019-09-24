using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesFtr
    {
        public string SalesFtrId { get; set; }
        public string SalesDtlId { get; set; }
        public string SoftrId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string UommasterId { get; set; }
        public string BatchNo { get; set; }
        public string WareHouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
    }
}
