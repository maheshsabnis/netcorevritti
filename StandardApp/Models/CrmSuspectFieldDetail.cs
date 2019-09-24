using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmSuspectFieldDetail
    {
        public string PkfieldId { get; set; }
        public string FkprospectHdrId { get; set; }
        public string ProspectField { get; set; }
        public string IsVisible { get; set; }
        public string IsMandatory { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string Caption { get; set; }
        public string Section { get; set; }
        public string FieldType { get; set; }
    }
}
