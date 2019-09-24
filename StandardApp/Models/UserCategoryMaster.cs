using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserCategoryMaster
    {
        public string PkuserCategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
