using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmAttachments
    {
        public string PkcallAttachmentId { get; set; }
        public string CallId { get; set; }
        public string Docpath { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDt { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
    }
}
