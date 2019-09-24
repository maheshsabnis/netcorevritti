using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class RfqvendorDetails
    {
        public string RfqvendorDetailsId { get; set; }
        public string RfqdtlId { get; set; }
        public string SupplierId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Addeddt { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
