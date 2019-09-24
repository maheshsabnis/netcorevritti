using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCompetitorProductMaster
    {
        public string PkcompetitorProductId { get; set; }
        public string FkcompetitorId { get; set; }
        public string Product { get; set; }
        public string OurProduct { get; set; }
        public decimal Price { get; set; }
        public string Feature { get; set; }
        public string IsDeleted { get; set; }
    }
}
