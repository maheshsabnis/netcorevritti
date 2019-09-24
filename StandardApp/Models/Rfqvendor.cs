using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Rfqvendor
    {
        public string RfqvendorId { get; set; }
        public string RfqheaderId { get; set; }
        public string ItemMasterId { get; set; }
        public string SupplierId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
