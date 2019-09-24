﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AmndSoschedule
    {
        public string AmndSoscheduleId { get; set; }
        public string AmndSodetailId { get; set; }
        public string ItemMasterId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public DateTime? SailingDate { get; set; }
        public decimal? Qty { get; set; }
        public string PlantId { get; set; }
        public string WarehouseId { get; set; }
        public decimal? Moqty { get; set; }
        public decimal? ActualMoqty { get; set; }
        public decimal? ShipmentQty { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SoscheduleStatus { get; set; }
        public string ItemProcessId { get; set; }
        public decimal? NoOfPack { get; set; }
        public decimal? QtyWithYield { get; set; }
        public decimal? CrtnAlloctdQty { get; set; }
    }
}
