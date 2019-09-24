using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MostockAlloc
    {
        public string MostockAllocId { get; set; }
        public string ModetailId { get; set; }
        public string StockDetailsId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? AllocQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public decimal? IssueQty { get; set; }
    }
}
