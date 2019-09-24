using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CartonTransHistory
    {
        public string CartonTransHistoryId { get; set; }
        public string CartonHeaderId { get; set; }
        public string CartonStockDetailId { get; set; }
        public string TransCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? NewQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsTransWithPackItemPost { get; set; }
        public string CartonProdNo { get; set; }
        public DateTime? CartonProdDate { get; set; }
        public string RefType { get; set; }
        public string RefId { get; set; }
    }
}
