using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProdDownTimeDetail
    {
        public string ProdDownTimeDetailId { get; set; }
        public string ProdEntryId { get; set; }
        public string MachineMasterId { get; set; }
        public string McnDwnRsnMasterId { get; set; }
        public DateTime? DwnTimeFrom { get; set; }
        public DateTime? DwnTimeTo { get; set; }
        public decimal? DownTime { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
