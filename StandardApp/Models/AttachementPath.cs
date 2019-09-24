using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class AttachementPath
    {
        public int DirectoryId { get; set; }
        public string Type { get; set; }
        public string Foldername { get; set; }
        public string Path { get; set; }
    }
}
