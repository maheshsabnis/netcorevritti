using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DocumentTypeMaster
    {
        public string PkdocType { get; set; }
        public string TypeDesc { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
