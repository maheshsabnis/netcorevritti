using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslVcFtpcredentials
    {
        public string Ftpid { get; set; }
        public DateTime? EffectiveFromDt { get; set; }
        public DateTime? EffectiveToDt { get; set; }
        public string ComponentKey { get; set; }
        public string FtpuserId { get; set; }
        public string FtpuserPwd { get; set; }
        public string HostName { get; set; }
        public string HostIp { get; set; }
        public string CreationLevel { get; set; }
        public string UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SyncInfo { get; set; }
        public bool? IsauthTls { get; set; }
        public bool? Isssl { get; set; }
    }
}
