using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProdBackFlushLot
    {
        public string ProdBackFlushId { get; set; }
        public string ProductionDetailId { get; set; }
        public string ModetailId { get; set; }
        public string ItemMasterId { get; set; }
        public string StockDetailsId { get; set; }
        public string BatchNo { get; set; }
        public decimal? BatchQty { get; set; }
        public decimal? TotalBackFlushQty { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
