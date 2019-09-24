using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ClassificationMaster
    {
        public string ClassificationId { get; set; }
        public string ItemClassificationId { get; set; }
        public string ParentItemClassificationId { get; set; }
    }
}
