using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserWidgetCombination
    {
        public string UserWidComId { get; set; }
        public string WidgetId { get; set; }
        public string UserId { get; set; }
        public string Position { get; set; }
        public decimal? SequenceNo { get; set; }
    }
}
