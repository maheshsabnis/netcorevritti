using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmMailinglistDtl
    {
        public string PkmaillistDtlId { get; set; }
        public string FkmailListId { get; set; }
        public string FkprospectId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
