using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class InvoiceDetail
    {
        public string InvoiceDetailId { get; set; }
        public string InvoiceHeaderId { get; set; }
        public string SalesHeaderId { get; set; }
        public decimal? TotGrossAmnt { get; set; }
        public decimal? TotTaxAmnt { get; set; }
        public decimal? DiscPer { get; set; }
        public decimal? DiscAmnt { get; set; }
        public decimal? TotNetAmnt { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public string SalesDtlId { get; set; }
        public decimal? TotGrossAmtFc { get; set; }
        public decimal? TotTaxAmtFc { get; set; }
        public decimal? TotDiscAmtFc { get; set; }
        public decimal? TotNetAmtFc { get; set; }
        public decimal? RetQty { get; set; }
    }
}
