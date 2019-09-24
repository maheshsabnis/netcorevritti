using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmailList
    {
        public string EmailListId { get; set; }
        public string SeqNo { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string IsActive { get; set; }
        public string ActivityCreation { get; set; }
        public string ConnString { get; set; }
        public string TableName { get; set; }
        public string IsFtppath { get; set; }
    }
}
