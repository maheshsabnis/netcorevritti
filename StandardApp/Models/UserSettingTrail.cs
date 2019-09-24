using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserSettingTrail
    {
        public string PksettingTrailId { get; set; }
        public string PksettingId { get; set; }
        public string FkuserMasterId { get; set; }
        public string FkprojectId { get; set; }
        public string FkfunctionId { get; set; }
        public decimal? TimeIncrementInMinutes { get; set; }
        public string CurrentDelegateId { get; set; }
        public string PreviousDelegateId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string UserPassword { get; set; }
        public string WayOfCommunication { get; set; }
        public string OtherInfo { get; set; }
    }
}
