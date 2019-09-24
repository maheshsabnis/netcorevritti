using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmTalukaMaster
    {
        public string PktalukaId { get; set; }
        public string TalukaNo { get; set; }
        public string TalukaDesc { get; set; }
        public string FkdistrictId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
