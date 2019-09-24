using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssformsMaster
    {
        public string PkcssFormsId { get; set; }
        public string CssformsCode { get; set; }
        public string CssformsDesc { get; set; }
        public string FksalesFamilyId { get; set; }
        public DateTime EffectiveFrmDt { get; set; }
        public DateTime EffectiveToDt { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string CoordinatorId { get; set; }
        public string IsCompletionMailSent { get; set; }
        public string MailPercentage { get; set; }
        public string SubCoordinator { get; set; }
        public string WebsiteLink { get; set; }
        public string IsReminder { get; set; }
        public string ReminderFrequency { get; set; }
        public int? ReminderCount { get; set; }
        public bool? IsWeightage { get; set; }
        public string UseForProspect { get; set; }
    }
}
