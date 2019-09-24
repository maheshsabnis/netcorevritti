using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Priority
    {
        public string PriorityId { get; set; }
        public string PriorityName { get; set; }
        public string Colour { get; set; }
        public decimal? PriorityIndex { get; set; }
    }
}
