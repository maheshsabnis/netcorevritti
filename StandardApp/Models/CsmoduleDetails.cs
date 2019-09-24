using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CsmoduleDetails
    {
        public decimal CsmoduleId { get; set; }
        public string ModuleNickName { get; set; }
        public string Dllname { get; set; }
        public string Namespace { get; set; }
        public string Module { get; set; }
        public string IsDeleted { get; set; }
    }
}
