using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ModuleSetup
    {
        public string ModuleSetupId { get; set; }
        public string ModuleSetupDesc { get; set; }
        public string ModuleDisplayValue { get; set; }
        public string ModuleSetupValue { get; set; }
        public string ModuleType { get; set; }
        public bool? IsUserControl { get; set; }
        public string UserControlName { get; set; }
        public string SetupType { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
