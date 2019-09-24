using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BinAcrcyDtl
    {
        public string BinAcrcyDtlId { get; set; }
        public string BinAcrcyHdrId { get; set; }
        public string ItemPlantId { get; set; }
        public string Lotno { get; set; }
        public string LocationId { get; set; }
        public DateTime? Fifo { get; set; }
        public string Confirmed { get; set; }
        public string NewLocId { get; set; }
        public string IsDeleted { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string StockDetailsId { get; set; }
        public decimal? Qty { get; set; }
    }
}
