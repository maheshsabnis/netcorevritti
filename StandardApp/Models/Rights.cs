using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rights
    {
        public decimal RightsId { get; set; }
        public string ModuleRolesId { get; set; }
        public decimal? UserGroupId { get; set; }
        public string UserMasterId { get; set; }
    }
}
