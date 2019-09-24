using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ApplicationMaster
    {
        public string PkappMaster { get; set; }
        public string AppDesc { get; set; }
        public string ApplicationName { get; set; }
        public string ServerApiKey { get; set; }
        public string SenderId { get; set; }
    }
}
