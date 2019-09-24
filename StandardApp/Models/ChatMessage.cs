using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChatMessage
    {
        public string ChatMessageId { get; set; }
        public string ChatRoomId { get; set; }
        public string SenderId { get; set; }
        public DateTime MsgDateTime { get; set; }
        public string MsgString { get; set; }
        public string MsgType { get; set; }

        public virtual ChatRoomMaster ChatRoom { get; set; }
        public virtual ChatUserMaster Sender { get; set; }
    }
}
