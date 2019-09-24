using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserGroupRelationOld
    {
        public decimal UserGroupRelationId { get; set; }
        public decimal? UserGroupId { get; set; }
        public decimal? UserMasterId { get; set; }
        public decimal? UserPrefOrder { get; set; }
    }
}
