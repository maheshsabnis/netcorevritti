using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class QueuingListDetail
    {
        public string QueuingListDetailId { get; set; }
        public string QueuingListHeaderId { get; set; }
        public string PccardMasterId { get; set; }
        public decimal? Pcqty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
