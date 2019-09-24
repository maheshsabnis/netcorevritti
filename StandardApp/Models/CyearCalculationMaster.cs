using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CyearCalculationMaster
    {
        public int Cycid { get; set; }
        public string UserMasterId { get; set; }
        public string Year { get; set; }
        public string Event { get; set; }
        public string Cl { get; set; }
        public string Sl { get; set; }
        public string Pl { get; set; }
        public string El { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string CreationLevel { get; set; }
        public string UserLevel { get; set; }
        public string SyncInfo { get; set; }
    }
}
