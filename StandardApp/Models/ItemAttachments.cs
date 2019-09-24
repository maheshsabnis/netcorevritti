using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemAttachments
    {
        public string ItemAttachmentsId { get; set; }
        public string ItemPlantId { get; set; }
        public string AttachGuid { get; set; }
        public string AttachFilename { get; set; }
        public string AttachFileDesc { get; set; }
        public string SourceId { get; set; }
        public string Sourcetype { get; set; }
        public string AttachmentType { get; set; }
        public string PlantId { get; set; }
        public string AddedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? AddedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
