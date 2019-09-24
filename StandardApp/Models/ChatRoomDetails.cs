using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ChatRoomDetails
    {
        public string ChatRoomDetailsId { get; set; }
        public string ChatRoomId { get; set; }
        public string UserMasterId { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public string Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
