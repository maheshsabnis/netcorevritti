using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ArchActivityAttachements
    {
        public string ArchAttachmentId { get; set; }
        public string ArchiveHistoryId { get; set; }
        public string PkAttachId { get; set; }
        public string AttachGuid { get; set; }
        public string AttachFilename { get; set; }
        public string Path { get; set; }
        public string ActivityId { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
        public string Sourcetype { get; set; }
        public string SourceId { get; set; }
        public string Gpsid { get; set; }
        public string AttachmentType { get; set; }
    }
}
