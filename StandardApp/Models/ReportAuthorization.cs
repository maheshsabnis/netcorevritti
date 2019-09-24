using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ReportAuthorization
    {
        public string PkauthorizationId { get; set; }
        public string ReportCode { get; set; }
        public string UserId { get; set; }
        public bool? IsUserGroup { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SyncInfo { get; set; }
    }
}
