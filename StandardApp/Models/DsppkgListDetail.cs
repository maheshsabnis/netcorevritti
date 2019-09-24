using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DsppkgListDetail
    {
        public string DsppkgListDetailId { get; set; }
        public string DsppkgListHeaderId { get; set; }
        public string SalesHeaderId { get; set; }
        public string StatusId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
    }
}
