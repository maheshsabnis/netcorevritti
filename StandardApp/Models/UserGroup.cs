using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserGroup
    {
        public string PkuserGroupId { get; set; }
        public string UserGroupName { get; set; }
        public string Remarks { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
