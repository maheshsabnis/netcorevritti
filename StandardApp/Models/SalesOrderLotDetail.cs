using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class SalesOrderLotDetail
    {
        public string SalesOrderLotDetaillId { get; set; }
        public string SalesOrderDetailId { get; set; }
        public string ItemMasterId { get; set; }
        public string LotNo { get; set; }
        public decimal? LotQty { get; set; }
        public DateTime? ActualProdDt { get; set; }
        public string ShipmentModeMasterId { get; set; }
        public string DeliveryTerms { get; set; }
        public DateTime? SailingDate { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string ConsigneeAddress { get; set; }
        public string TransporterAddress { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
