using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCompetitorAgainstCall
    {
        public string Pkid { get; set; }
        public string CallId { get; set; }
        public string FkcompetitorId { get; set; }
        public string IsDeleted { get; set; }
    }
}
