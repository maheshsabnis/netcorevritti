using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class WarrantyMaster
    {
        public string WarrantyMasterId { get; set; }
        public string WarrantyCode { get; set; }
        public string WarrantyDesc { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsActive { get; set; }
        public string Modeofsupport { get; set; }
        public string IslicenseRequired { get; set; }
        public decimal? MaterialCharge { get; set; }
        public decimal? WarrantyExpiresAfter { get; set; }
        public decimal? WarrantyDisplaytill { get; set; }
    }
}
