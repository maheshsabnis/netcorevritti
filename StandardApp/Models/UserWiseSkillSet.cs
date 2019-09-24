using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserWiseSkillSet
    {
        public string PkuesrWiseSkillId { get; set; }
        public string FkuserMasterId { get; set; }
        public string FkskillId { get; set; }
        public string Rating { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
