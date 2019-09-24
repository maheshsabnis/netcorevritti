using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DefaultWebPages
    {
        public int DefaultPageId { get; set; }
        public string PageDesc { get; set; }
        public string TechnicalName { get; set; }
        public string IsDeleted { get; set; }
    }
}
