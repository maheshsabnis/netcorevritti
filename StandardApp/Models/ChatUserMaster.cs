using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChatUserMaster
    {
        public ChatUserMaster()
        {
            ChatMessage = new HashSet<ChatMessage>();
        }

        public string UserMasterId { get; set; }
        public bool Online { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<ChatMessage> ChatMessage { get; set; }
    }
}
