using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmailListTimesheetExcel
    {
        public string EmailListId { get; set; }
        public decimal? SeqNo { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string IsActive { get; set; }
        public string ActivityCreation { get; set; }
        public string ConnString { get; set; }
        public string TableName { get; set; }
        public string IsFtppath { get; set; }
        public string Popserver { get; set; }
        public bool? UseLocalfolder { get; set; }
        public string Ftpserver { get; set; }
        public string FolderPath { get; set; }
        public string Smtpserver { get; set; }
        public string UserName { get; set; }
    }
}
