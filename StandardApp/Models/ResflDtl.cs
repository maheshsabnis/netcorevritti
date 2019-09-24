using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ResflDtl
    {
        public string ResflDtlId { get; set; }
        public string ResflHdrId { get; set; }
        public string ItemPlantId { get; set; }
        public string WarehouseId { get; set; }
        public string FromLocationId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? Fifo { get; set; }
        public decimal? Qty { get; set; }
        public string SuggLocationId { get; set; }
        public decimal? SuggQty { get; set; }
        public string ActualLocationId { get; set; }
        public decimal? ActualQty { get; set; }
        public string Status { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? PostedDate { get; set; }
        public string StockDetailsId { get; set; }
    }
}
