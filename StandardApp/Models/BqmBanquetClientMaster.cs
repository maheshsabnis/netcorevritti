using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BqmBanquetClientMaster
    {
        public string BqmBanquetClientId { get; set; }
        public string CustVendorMasterId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string TypeOfClient { get; set; }
        public string ToBeDeleted { get; set; }
        public string Remarks { get; set; }
        public string IsDeleted { get; set; }
    }
}
