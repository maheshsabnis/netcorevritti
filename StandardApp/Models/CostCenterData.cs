using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CostCenterData
    {
        public string RecId { get; set; }
        public string PlantId { get; set; }
        public string PartyTypeId { get; set; }
        public string CostCenterId { get; set; }
        public string OrderTypeId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
