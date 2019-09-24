using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class LeftOvrHdr
    {
        public string LeftOvrHdrId { get; set; }
        public string DocNo { get; set; }
        public DateTime? Docdt { get; set; }
        public DateTime? Addeddt { get; set; }
        public string AddedBy { get; set; }
    }
}
