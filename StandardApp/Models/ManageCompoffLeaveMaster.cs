using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ManageCompoffLeaveMaster
    {
        public string PkemployeeleaveId { get; set; }
        public string UserMasterId { get; set; }
        public string LeaveCode { get; set; }
        public DateTime? ExtraWorkingDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsDeleted { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public decimal? ApprovalStatus { get; set; }
        public string Remarks { get; set; }
        public decimal? Workingdays { get; set; }
        public string ApproverRemark { get; set; }
        public string CompOffStatus { get; set; }
    }
}
