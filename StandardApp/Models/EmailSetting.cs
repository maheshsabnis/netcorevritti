using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmailSetting
    {
        public string EmailSettingId { get; set; }
        public string ServerName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Recipients { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? FromEmailRequired { get; set; }
        public bool? EnableSsl { get; set; }
        public decimal? MaximumEmailCount { get; set; }
        public bool? UseDefaultCredentials { get; set; }
        public bool? IsBodyHtml { get; set; }
        public string Priority { get; set; }
        public string IsDefault { get; set; }
        public string EmailId { get; set; }
    }
}
