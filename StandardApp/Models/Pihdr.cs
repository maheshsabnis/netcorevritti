using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Pihdr
    {
        public string PihdrId { get; set; }
        public string Code { get; set; }
        public string PlantId { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public string Status { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string Remark { get; set; }
    }
}
