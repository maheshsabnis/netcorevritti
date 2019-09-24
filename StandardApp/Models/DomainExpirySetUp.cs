using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DomainExpirySetUp
    {
        public string DomainId { get; set; }
        public DateTime? DomainDate { get; set; }
        public string DomainStatus { get; set; }
    }
}
