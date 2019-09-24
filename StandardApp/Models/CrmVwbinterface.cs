using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmVwbinterface
    {
        public string PkvwbintrfaceId { get; set; }
        public string FkproductId { get; set; }
        public string FkprojectId { get; set; }
        public string FkmoduleId { get; set; }
        public string FkunitId { get; set; }
        public bool? IsProductLevel { get; set; }
        public bool? IsSystemLevel { get; set; }
        public string IsDeleted { get; set; }
    }
}
