using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMailinglistMaster
    {
        public string PkmaillistId { get; set; }
        public string MailListName { get; set; }
        public string FkprimaryController { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
