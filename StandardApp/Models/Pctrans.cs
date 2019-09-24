using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Pctrans
    {
        public string PctransId { get; set; }
        public string PccardMasterId { get; set; }
        public string PlantMasterId { get; set; }
        public string MoheaderId { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
    }
}
