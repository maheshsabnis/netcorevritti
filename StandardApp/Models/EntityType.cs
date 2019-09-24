using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EntityType
    {
        public string RecId { get; set; }
        public string TypeCode { get; set; }
        public string TypeDesc { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
