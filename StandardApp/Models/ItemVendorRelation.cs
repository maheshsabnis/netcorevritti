using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemVendorRelation
    {
        public string ItemVendorRelationId { get; set; }
        public string ItemMasterId { get; set; }
        public string PlantId { get; set; }
        public string VendorMasterId { get; set; }
        public bool? IsPrimaryVendor { get; set; }
        public string TaxClassMasterId { get; set; }
        public string CatalogNo { get; set; }
        public string PurUnit { get; set; }
        public decimal? PurRate { get; set; }
        public decimal? DiscRate { get; set; }
        public decimal? Eoq { get; set; }
        public decimal? PurLeadTimeVendor { get; set; }
        public decimal? PurLeadTimeSafety { get; set; }
        public decimal? MultipleQty { get; set; }
        public decimal? MinOrderQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
