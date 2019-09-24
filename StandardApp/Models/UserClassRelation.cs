using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserClassRelation
    {
        public string UserClassrelId { get; set; }
        public string UserClassId { get; set; }
        public string UserMasterId { get; set; }
        public string UserGroupId { get; set; }
    }
}
