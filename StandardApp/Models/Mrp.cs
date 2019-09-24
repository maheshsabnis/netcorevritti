using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mrp
    {
        public string Mrpid { get; set; }
        public DateTime? Mrpfrom { get; set; }
        public DateTime? Mrpto { get; set; }
        public string PlantMasterId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
