using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserSkillApproval
    {
        public string PkuserSkillApprId { get; set; }
        public string FkuserMasterId { get; set; }
        public string FkskillId { get; set; }
        public string LastRating { get; set; }
        public string RatingRequired { get; set; }
        public string ApprovedBy { get; set; }
        public bool? IsApproved { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? IsCancel { get; set; }
    }
}
