using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChatRoomMaster
    {
        public ChatRoomMaster()
        {
            ChatMessage = new HashSet<ChatMessage>();
        }

        public string ChatRoomId { get; set; }
        public string InitiatorId { get; set; }
        public string ChatRoomName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public string ChatSource { get; set; }
        public string ChatSourceType { get; set; }
        public string ChatSourceId { get; set; }
        public string Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ApplicationCode { get; set; }
        public string ChatType { get; set; }

        public virtual ICollection<ChatMessage> ChatMessage { get; set; }
    }
}
