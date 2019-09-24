using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTerrUserRelation
    {
        public string PkterritoryUserRelId { get; set; }
        public string FkterritoryId { get; set; }
        public string FkuserMasterId { get; set; }
        public string IsDeleted { get; set; }
    }
}
