using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ConfigurationDetail
    {
        public string ConfigurationDetailId { get; set; }
        public string ConfigurationMasterId { get; set; }
        public string Code { get; set; }
        public string Configuration { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? NoOfDays { get; set; }
    }
}
