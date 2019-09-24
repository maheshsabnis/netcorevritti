using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Tds16aemailRecords
    {
        public string RecId { get; set; }
        public string EntityCode { get; set; }
        public string EntityName { get; set; }
        public string Email { get; set; }
        public string Panno { get; set; }
        public DateTime? EmailSentDt { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
