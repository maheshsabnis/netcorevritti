using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Album
    {
        public Album()
        {
            PhotAlbum = new HashSet<PhotAlbum>();
        }

        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public int? DefaultPhotId { get; set; }

        public virtual ICollection<PhotAlbum> PhotAlbum { get; set; }
    }
}
