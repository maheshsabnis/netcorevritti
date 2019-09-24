using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rmdaheader
    {
        public string RmdaheaderId { get; set; }
        public string Rmdano { get; set; }
        public DateTime? Rmdadt { get; set; }
        public string PlantId { get; set; }
        public string RequistionerId { get; set; }
        public string SupplierId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string StatusId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDt { get; set; }
        public string CurrencyMasterId { get; set; }
        public string Remark { get; set; }
        public string RefRecId { get; set; }
        public string RefRecType { get; set; }
        public string RefBillNo { get; set; }
        public DateTime? RefBillDt { get; set; }
        public decimal? ExchRate { get; set; }
    }
}
