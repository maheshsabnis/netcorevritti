﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VslSourceType
    {
        public string SourceTypeId { get; set; }
        public string AssemblyName { get; set; }
        public string Class { get; set; }
        public string KeyValue { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string SyncInfo { get; set; }
    }
}