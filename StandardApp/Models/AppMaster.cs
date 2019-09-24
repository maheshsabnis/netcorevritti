using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AppMaster
    {
        public decimal AppId { get; set; }
        public string Appname { get; set; }
        public string IconFile { get; set; }
        public string WebUrl { get; set; }
        public string Isdeleted { get; set; }
    }
}
