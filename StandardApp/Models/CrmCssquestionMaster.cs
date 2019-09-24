using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssquestionMaster
    {
        public string PkquesId { get; set; }
        public string QuesCode { get; set; }
        public string QuesText { get; set; }
        public string ResponseType { get; set; }
        public int ValueMin { get; set; }
        public int ValueMax { get; set; }
        public string SelectionText { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string SelectionValue { get; set; }
        public string Notes { get; set; }
        public string MaxValueText { get; set; }
        public string SelectionType { get; set; }
        public int? ControlWidth { get; set; }
        public string IsExtMaster { get; set; }
        public string ExtMasterName { get; set; }
    }
}
