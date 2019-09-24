using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmItemClassification
    {
        public string PkitemClassId { get; set; }
        public string ErpitemClassId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
