using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class BoxTypeMaster
    {
        public string BoxTypeMasterId { get; set; }
        public string BoxCode { get; set; }
        public string BoxName { get; set; }
        public decimal? BoxWeight { get; set; }
        public string Box { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? Lbhbreadth { get; set; }
        public decimal? Lbhheight { get; set; }
        public decimal? Lbhlength { get; set; }
    }
}
