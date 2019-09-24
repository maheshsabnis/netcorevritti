using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssdetail
    {
        public string PkcssDtlsId { get; set; }
        public string FkquesId { get; set; }
        public string FkcssHeaderId { get; set; }
        public string ResponseByCustomer { get; set; }
        public string SelectionValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string Remarks { get; set; }
        public string Note { get; set; }
    }
}
