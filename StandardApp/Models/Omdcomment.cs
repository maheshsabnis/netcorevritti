using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Omdcomment
    {
        public string OmdcommentId { get; set; }
        public string SoScheduleId { get; set; }
        public string CommentType { get; set; }
        public string Addedby { get; set; }
        public DateTime? Addeddt { get; set; }
        public string Comment { get; set; }
    }
}
