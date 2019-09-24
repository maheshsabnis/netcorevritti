using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslVcMailDataMaster
    {
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string MessageCc { get; set; }
        public string MessageBcc { get; set; }
        public string MessageSubject { get; set; }
        public byte[] MessageBody { get; set; }
        public string MessageType { get; set; }
        public DateTime? MessageSentAt { get; set; }
        public string MessageStatus { get; set; }
        public string MessageRemark { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ExpiryTime { get; set; }
        public string MessageId { get; set; }
        public string AccountType { get; set; }
    }
}
