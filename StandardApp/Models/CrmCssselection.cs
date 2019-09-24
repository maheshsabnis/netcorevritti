using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssselection
    {
        public string PkcssSelectionId { get; set; }
        public string FkquesId { get; set; }
        public string SelectionText { get; set; }
        public int SelectionValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
