using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaxRateTaxClass
    {
        public string TaxrateTaxClassMasterId { get; set; }
        public decimal? TaxRate { get; set; }
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public string InIntraStateTaxclassid { get; set; }
        public string InInterStateTaxclassid { get; set; }
        public string InIntraUtTaxclassid { get; set; }
        public string InFromSeztaxclassid { get; set; }
        public string InImportTaxclassid { get; set; }
        public string OpIntraStateTaxclassid { get; set; }
        public string OpInterStateTaxclassid { get; set; }
        public string OpIntraUtTaxclassid { get; set; }
        public string OpFromSeztaxclassid { get; set; }
        public string OpExportTaxclassid { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
