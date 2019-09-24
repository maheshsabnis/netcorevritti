using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PurchaseRegisterSummary
    {
        public string PkpurchaseSumId { get; set; }
        public string VendorGstin { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? InvoiceValue { get; set; }
        public decimal? TaxableValue { get; set; }
        public decimal? Rate { get; set; }
        public decimal? SystemSgst { get; set; }
        public decimal? SystemCgst { get; set; }
        public decimal? SystemIgst { get; set; }
        public decimal? SystemCess { get; set; }
        public string PlantId { get; set; }
        public string Pan { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string OurGstin { get; set; }
        public decimal? Srno { get; set; }
        public string GenericField1 { get; set; }
        public string Projectcode { get; set; }
        public string InternalRefDocNo { get; set; }
        public string Match { get; set; }
        public decimal? TaxAmt { get; set; }
        public string Fyid { get; set; }
    }
}
