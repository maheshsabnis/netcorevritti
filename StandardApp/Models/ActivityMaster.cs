using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ActivityMaster
    {
        public string ActivityMasterId { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityDesc { get; set; }
        public string ExeResponsibility { get; set; }
        public string Email { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
