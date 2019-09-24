using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemRoutingHeader
    {
        public string ItemRoutingHeaderId { get; set; }
        public string ItemRoutingCode { get; set; }
        public string RoutingDescription { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? LotSize { get; set; }
        public string ItemRoutingContains { get; set; }
        public string ItemClassificationId { get; set; }
        public string PlantId { get; set; }
    }
}
