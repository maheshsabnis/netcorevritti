using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserGroupRelation
    {
        public string PkuserGroupRelationId { get; set; }
        public string UserGroupId { get; set; }
        public string UserMasterId { get; set; }
        public decimal? UserPrefOrder { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
