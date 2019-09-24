using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmQuotation
    {
        public string PkquotationId { get; set; }
        public string CallId { get; set; }
        public string ExecutiveId { get; set; }
        public string QuotationNo { get; set; }
        public decimal? OuotationValue { get; set; }
        public DateTime? QuotationDatetime { get; set; }
        public string QuotationDocPath { get; set; }
        public bool? StatusFlag { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string QuatationFileName { get; set; }
    }
}
