using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmployeeSkillSet
    {
        public string EmpSkillSetId { get; set; }
        public string SkillSetId { get; set; }
        public string EmployeeId { get; set; }
        public int? SkillLevel { get; set; }
        public string IsDeleted { get; set; }
    }
}
