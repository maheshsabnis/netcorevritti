using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslVcAttachmentMaster
    {
        public string MsgId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
        public string AttachmentId { get; set; }
    }
}
