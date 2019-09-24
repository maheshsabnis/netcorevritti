using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TicketMaterialConsumption
    {
        public string PkTicketMaterialConsumptionId { get; set; }
        public string ActivityId { get; set; }
        public string ItemPlantId { get; set; }
        public string WarehouseId { get; set; }
        public string LocationId { get; set; }
        public string Uomid { get; set; }
        public string FieldName { get; set; }
        public decimal? ConsumedQty { get; set; }
        public string Remark { get; set; }
        public string Isdeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
