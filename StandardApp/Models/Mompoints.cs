using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Mompoints
    {
        public string MompointId { get; set; }
        public string Momid { get; set; }
        public int? SrNo { get; set; }
        public string MompointDesc { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
