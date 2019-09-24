using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BillHeader
    {
        public string BillHeaderId { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public decimal? BillAmount { get; set; }
        public string VouRefId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
