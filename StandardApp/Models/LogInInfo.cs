using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LogInInfo
    {
        public string UserMasterId { get; set; }
        public string UserLoginId { get; set; }
        public DateTime? SignInDateTime { get; set; }
        public DateTime? SignOutDateTime { get; set; }
        public string Session { get; set; }
        public string PklogInInfoId { get; set; }
        public string Ipaddress { get; set; }
    }
}
