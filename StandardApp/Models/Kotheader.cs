using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Kotheader
    {
        public string KotheaderId { get; set; }
        public string Kotno { get; set; }
        public DateTime? Kotdate { get; set; }
        public string Kotstatus { get; set; }
        public string MachineGrpDetailId { get; set; }
        public decimal? TotalOrder { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public DateTime? KotcompletedOn { get; set; }
        public DateTime? KotdeliveredOn { get; set; }
        public string BillNo { get; set; }
        public string ShiftId { get; set; }
    }
}
