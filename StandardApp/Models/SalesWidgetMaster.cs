using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesWidgetMaster
    {
        public string PksalesWidgetMasterId { get; set; }
        public string FkplantId { get; set; }
        public string Particular { get; set; }
        public decimal? ThisMth { get; set; }
        public decimal? FromApril { get; set; }
        public int? DueDays { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string WidgetCode { get; set; }
        public decimal? SeqNo { get; set; }
    }
}
