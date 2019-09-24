using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCollectionCallErrLog
    {
        public string CollectionErrId { get; set; }
        public string InvoiceNo { get; set; }
        public string Seid { get; set; }
        public string CustomerId { get; set; }
        public string PartyName { get; set; }
        public string SouceId { get; set; }
        public DateTime? NextActionDateTime { get; set; }
        public decimal? Amount { get; set; }
        public string Isclose { get; set; }
        public string Reason { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
