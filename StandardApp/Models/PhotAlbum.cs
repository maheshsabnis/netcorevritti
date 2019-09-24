using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class PhotAlbum
    {
        public int PhotoId { get; set; }
        public string Photo { get; set; }
        public string PhotoName { get; set; }
        public int? AlbumId { get; set; }
        public string OriginalPath { get; set; }

        public virtual Album Album { get; set; }
    }
}
