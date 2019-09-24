using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemClassPrefLoc
    {
        public string ItemClassPrefLocId { get; set; }
        public string ItemClassificationId { get; set; }
        public int? Preference { get; set; }
        public string Aisle { get; set; }
        public string BayFrom { get; set; }
        public string BayTo { get; set; }
        public string LevelFrom { get; set; }
        public string LevelTo { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
