using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmcallAllocation
    {
        public string PkallocationId { get; set; }
        public string FksuspectId { get; set; }
        public string FkallocateTo { get; set; }
        public string FkproductId { get; set; }
    }
}
