using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ForeignKeyTracker
    {
        public decimal ForeignKeyTrackerId { get; set; }
        public string MasterTable { get; set; }
        public string ChildTable { get; set; }
        public string ChildCol { get; set; }
        public string ChildTableDesc { get; set; }
    }
}
