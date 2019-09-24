using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rfqdetail
    {
        public string RfqdtlId { get; set; }
        public string RfqhdrId { get; set; }
        public string PlantMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Qty { get; set; }
        public string PurchaseGrpId { get; set; }
        public string Remark { get; set; }
        public string UommasterId { get; set; }
        public string Notes { get; set; }
    }
}
