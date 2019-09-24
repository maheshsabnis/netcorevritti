using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ReplyMessages
    {
        public string MsgId { get; set; }
        public string DocType { get; set; }
        public string EmailText { get; set; }
        public string Smstext { get; set; }
    }
}
