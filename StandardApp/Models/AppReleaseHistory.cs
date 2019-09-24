using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AppReleaseHistory
    {
        public string HistoryId { get; set; }
        public string Designelement { get; set; }
        public string Version { get; set; }
        public string Changes { get; set; }
        public string UploadFtp { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Isdeleted { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? Userlevel { get; set; }
        public string SyncInfo { get; set; }
        public string ActivityId { get; set; }
        public string Steps { get; set; }
        public string Prerequistes { get; set; }
        public string Precaution { get; set; }
        public string Condition { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewedRemark { get; set; }
        public DateTime? ReviewedDt { get; set; }
        public string MailTo { get; set; }
        public string MailCc { get; set; }
        public string MailBcc { get; set; }
        public string FolderPath { get; set; }
    }
}
