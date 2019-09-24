using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WidgetMaster
    {
        public int WidgetId { get; set; }
        public string WidgetName { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string WidgetOfApplication { get; set; }
        public string PageUrl { get; set; }
        public bool? IsActive { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ColorCode { get; set; }
        public string TechnicalName { get; set; }
    }
}
