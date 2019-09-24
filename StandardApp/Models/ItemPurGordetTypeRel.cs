using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemPurGordetTypeRel
    {
        public string ItemPurGordetTypeRelId { get; set; }
        public string ItemPurchaseGroupId { get; set; }
        public string OrderTypeId { get; set; }
        public string PlantId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
