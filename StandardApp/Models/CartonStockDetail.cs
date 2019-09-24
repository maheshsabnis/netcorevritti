using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CartonStockDetail
    {
        public string CartonStockDetailId { get; set; }
        public string CartonHeaderId { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public string TransCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? RecvdQty { get; set; }
        public decimal? MovedQty { get; set; }
        public decimal? BalQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
