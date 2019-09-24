using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class MmContractDetail
    {
        public string ContractDetailId { get; set; }
        public string ContractHeaderId { get; set; }
        public string ItemPlantId { get; set; }
        public decimal? ContractRate { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
