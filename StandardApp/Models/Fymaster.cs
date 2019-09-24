using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Fymaster
    {
        public decimal RecId { get; set; }
        public string FymasterId { get; set; }
        public string Fycode { get; set; }
        public DateTime? Fysdate { get; set; }
        public DateTime? Fyedate { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ActiveForTarget { get; set; }
    }
}
