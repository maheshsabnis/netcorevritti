using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VwbEmpLeaveMaintenance
    {
        public string PkempLeaveId { get; set; }
        public string FkyearMasterId { get; set; }
        public string LeaveCode { get; set; }
        public decimal? OpenBal { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Consumed { get; set; }
        public decimal? Balance { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string FkuserMasterId { get; set; }
    }
}
