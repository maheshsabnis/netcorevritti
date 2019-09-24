using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class OrderTypeWisePrintingParameter
    {
        public string OrderTypeWisePrintId { get; set; }
        public string OrderTypeMasterId { get; set; }
        public string DocType { get; set; }
        public string Dllname { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Reporttype { get; set; }
    }
}
