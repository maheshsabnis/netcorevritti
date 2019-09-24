using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SkillSetMaster
    {
        public string PkskillSetId { get; set; }
        public string SkillSet { get; set; }
        public string SkillSetDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? AddedDt { get; set; }
        public string FkskillGroupId { get; set; }
        public string Flag { get; set; }
    }
}
