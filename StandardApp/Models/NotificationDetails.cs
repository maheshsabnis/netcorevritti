using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class NotificationDetails
    {
        public string PknotifDtlsId { get; set; }
        public string NotifTitle { get; set; }
        public string NotifContent { get; set; }
        public string NotificationTypeId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? DisplayFromDate { get; set; }
        public DateTime? DisplayToDate { get; set; }
        public string NotifText { get; set; }
        public string DateType { get; set; }
        public string DocNo { get; set; }
        public int? RevisionNo { get; set; }
    }
}
