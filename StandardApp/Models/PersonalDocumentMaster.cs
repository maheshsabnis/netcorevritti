using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PersonalDocumentMaster
    {
        public string PersonalDocumentMasterId { get; set; }
        public string DocCode { get; set; }
        public string DocTitle { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
