using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class FolderDeletion
    {
        public string ApplicationPath { get; set; }
        public string Folder { get; set; }
        public string FileText { get; set; }
        public string FileType { get; set; }
        public string WordFile { get; set; }
        public string ExcelFile { get; set; }
        public string PdfFile { get; set; }
    }
}
