using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SkillGroupMaster
    {
        public string PkskillGroupId { get; set; }
        public string SkillGroup { get; set; }
        public string SkillGroupDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
