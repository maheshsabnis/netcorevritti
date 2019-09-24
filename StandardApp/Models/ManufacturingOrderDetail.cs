using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ManufacturingOrderDetail
    {
        public string ManufacturingOrderDetailId { get; set; }
        public string ManufacturingOrderHeaderId { get; set; }
        public string CustOrderNo { get; set; }
        public string ItemMasterId { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? NoOfLots { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
