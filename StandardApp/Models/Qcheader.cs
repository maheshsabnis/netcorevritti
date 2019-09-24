using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Qcheader
    {
        public string QcheaderId { get; set; }
        public string Qccode { get; set; }
        public DateTime? Qcdt { get; set; }
        public string AuthorisedById { get; set; }
        public string ApprovedById { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
    }
}
