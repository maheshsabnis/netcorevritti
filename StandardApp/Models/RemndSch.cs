using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class RemndSch
    {
        public string RemndSchId { get; set; }
        public string EmailFrom { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public decimal? Offsetdays { get; set; }
        public string SchType { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
