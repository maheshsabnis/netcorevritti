using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Top10WidgetMaster
    {
        public string Pktop10WidgetMasterId { get; set; }
        public int? FkwidgetId { get; set; }
        public string Code { get; set; }
        public string PartyName { get; set; }
        public decimal? Balance { get; set; }
        public int? DueDays { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string WidgetCode { get; set; }
    }
}
