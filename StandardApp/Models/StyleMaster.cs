using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class StyleMaster
    {
        public string StyleMasterId { get; set; }
        public string CustomerMasterId { get; set; }
        public string StyleCode { get; set; }
        public string StyleDesc { get; set; }
        public string Construction { get; set; }
        public string SockType { get; set; }
        public byte[] SockImage { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
