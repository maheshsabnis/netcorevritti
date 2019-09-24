using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class NotificationType
    {
        public string PknotificationId { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsControlled { get; set; }
        public string IsInfoDocType { get; set; }
        public string NotificationType1 { get; set; }
    }
}
