using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCampaignMaster
    {
        public string PkcampaignId { get; set; }
        public string CampaignCode { get; set; }
        public string CampaignName { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Script { get; set; }
        public string CampaignType { get; set; }
        public string CampaignManager { get; set; }
    }
}
