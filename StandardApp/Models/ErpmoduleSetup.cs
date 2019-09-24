using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ErpmoduleSetup
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
        public string HelpText { get; set; }
    }
}
