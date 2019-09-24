using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LeaveCalculationMaster
    {
        public int Lcid { get; set; }
        public string UserMasterId { get; set; }
        public string Cl { get; set; }
        public string Sl { get; set; }
        public string Pl { get; set; }
        public string El { get; set; }
        public string Year { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string CreationLevel { get; set; }
        public string UserLevel { get; set; }
        public string SyncInfo { get; set; }
        public string Status { get; set; }
        public string LeaveType { get; set; }
        public DateTime? Startdt { get; set; }
        public DateTime? Enddt { get; set; }
    }
}
