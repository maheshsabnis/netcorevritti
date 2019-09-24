using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemCustomerRelation
    {
        public string ItemCustomerRelationId { get; set; }
        public string ItemMasterId { get; set; }
        public string CustomerId { get; set; }
        public string ItemCustomerCode { get; set; }
        public string PlantId { get; set; }
        public string SaleUnit { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string CurrencyMasterId { get; set; }
        public DateTime? EffectiveTo { get; set; }
    }
}
