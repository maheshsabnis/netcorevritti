using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTerritoryMaster
    {
        public string PkterritoryId { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string FkparentTerritoryId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string ManagerId { get; set; }
    }
}
