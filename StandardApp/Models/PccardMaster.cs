using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PccardMaster
    {
        public string PccardMasterId { get; set; }
        public string MoheaderId { get; set; }
        public string PccardNo { get; set; }
        public decimal? PccardQty { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PlantMasterId { get; set; }
        public decimal? CurrentPccardQty { get; set; }
        public string CurrentOperationId { get; set; }
        public string CurrentWiplocationId { get; set; }
        public string Segregation { get; set; }
        public string RecType { get; set; }
        public string RefRecType { get; set; }
        public string Status { get; set; }
        public string Pctype { get; set; }
        public string CurrentWipitemId { get; set; }
        public string CurrentMoroutingId { get; set; }
        public decimal? ProdQty { get; set; }
        public string TinShedStatus { get; set; }
        public string LocationMasterId { get; set; }
        public string PcsrNo { get; set; }
    }
}
