using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChatMessages
    {
        public string MessageId { get; set; }
        public string RoomId { get; set; }
        public string MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        public string UserId { get; set; }
        public bool IsSystem { get; set; }
        public string MessageType { get; set; }
        public string ChatAttachment { get; set; }
        public string IsDeleted { get; set; }
    }
}
