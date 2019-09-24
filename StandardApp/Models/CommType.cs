using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CommType
    {
        public string CommTypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeDesc { get; set; }
        public string VouMasterId { get; set; }
        public string Glid { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string CommOn { get; set; }
        public string PaymentTerms { get; set; }
        public string FinanceStatus { get; set; }
    }
}
