﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TaskAuthorityHistory
    {
        public string PktaskAuthHstryId { get; set; }
        public string FktaskAuthId { get; set; }
        public string FktaskId { get; set; }
        public string FkuserId { get; set; }
        public string UserGroupId { get; set; }
        public string AuthorisedAction { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
