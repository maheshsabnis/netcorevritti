using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class UserSetting
    {
        public string PksettingId { get; set; }
        public string FkuserMasterId { get; set; }
        public string FkprojectId { get; set; }
        public string FkfunctionId { get; set; }
        public decimal? TimeIncrementInMinutes { get; set; }
        public string DelegateId { get; set; }
        public string UserApplicationTheme { get; set; }
    }
}
