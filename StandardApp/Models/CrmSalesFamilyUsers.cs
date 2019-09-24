using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmSalesFamilyUsers
    {
        public string PksalesFmlyUserId { get; set; }
        public string FkfamilyId { get; set; }
        public string FkuserMasterId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public int MailSettingDays { get; set; }
    }
}
