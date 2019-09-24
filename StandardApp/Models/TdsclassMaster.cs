using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TdsclassMaster
    {
        public decimal RecId { get; set; }
        public string TdsclassMasterId { get; set; }
        public string FinDivId { get; set; }
        public string Tdscode { get; set; }
        public string Tdsdesc { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string AccountMasterId { get; set; }
        public string SecId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string VouMasterId { get; set; }
        public string EntityId { get; set; }
        public bool? TdsinclTx { get; set; }
    }
}
