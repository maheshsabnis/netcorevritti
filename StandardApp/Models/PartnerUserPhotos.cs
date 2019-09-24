using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PartnerUserPhotos
    {
        public string PkphotoId { get; set; }
        public string FkuserId { get; set; }
        public string UserLoginId { get; set; }
        public string FtpuserPath { get; set; }
        public string IsDeleted { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
