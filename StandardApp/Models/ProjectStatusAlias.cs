using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ProjectStatusAlias
    {
        public string PrjStatusAliasId { get; set; }
        public int? PrjStatusid { get; set; }
        public string PrjStatusAlias { get; set; }
        public bool? Active { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
