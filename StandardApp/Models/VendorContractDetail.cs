using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VendorContractDetail
    {
        public string VendorContractDetailId { get; set; }
        public string VendorContractHeaderId { get; set; }
        public string ItemMasterId { get; set; }
        public string UommasterId { get; set; }
        public string CurrencyMasterId { get; set; }
        public string Rate { get; set; }
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
