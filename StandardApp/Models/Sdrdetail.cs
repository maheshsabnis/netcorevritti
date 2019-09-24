using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Sdrdetail
    {
        public string SdrdetailId { get; set; }
        public string SdrheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? ReqDispatchQty { get; set; }
        public string WarehouseMasterId { get; set; }
        public string LocationMasterId { get; set; }
        public decimal? LotNo { get; set; }
        public string CustVendorMasterId { get; set; }
        public string Remark { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
