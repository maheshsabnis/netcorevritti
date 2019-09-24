using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqtQuotationFtr
    {
        public string BqtQuotationFtrId { get; set; }
        public string BqtQuotationDtlId { get; set; }
        public string BomdetailId { get; set; }
        public string ItemPlantId { get; set; }
        public string UommasterId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
