using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ManufacturingOrderHeader
    {
        public string ManufacturingOrderHeaderId { get; set; }
        public string OrderNo { get; set; }
        public string SalesOrderId { get; set; }
        public string SalesOrderLotId { get; set; }
        public string CustomerMasterId { get; set; }
        public string OrderDate { get; set; }
        public DateTime? ScheduledProdDate { get; set; }
        public decimal? LeadTime { get; set; }
        public bool? IsInhouse { get; set; }
        public string AuthorizedBy { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
