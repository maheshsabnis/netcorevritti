using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PctransHistory
    {
        public decimal PctransHistoryId { get; set; }
        public string PlantMasterId { get; set; }
        public string PcmasterId { get; set; }
        public DateTime? TransDt { get; set; }
        public decimal? Qty { get; set; }
        public string Segregation { get; set; }
        public string OperationId { get; set; }
        public string WipitemId { get; set; }
        public string ItemPlantId { get; set; }
        public string WiplocationId { get; set; }
        public DateTime? AddedDt { get; set; }
        public string AddedBy { get; set; }
    }
}
