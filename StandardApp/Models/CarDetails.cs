using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CarDetails
    {
        public string RecId { get; set; }
        public string MsgHeaderId { get; set; }
        public string MsgAttachmentId { get; set; }
        public byte[] Car { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDt { get; set; }
    }
}
