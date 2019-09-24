using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class VsApplErpmenu1
    {
        public string MenuId { get; set; }
        public string MenuCode { get; set; }
        public string MenuDesc { get; set; }
        public string ParentMenuCode { get; set; }
        public string Executable { get; set; }
        public int? Sequence { get; set; }
        public string ExecutionString { get; set; }
        public string AssemblyName { get; set; }
        public string PageName { get; set; }
        public string CheckPreLoadCondition { get; set; }
        public decimal? IconId { get; set; }
        public string MenuShortCut { get; set; }
        public decimal? UserRightValue { get; set; }
        public string IsDeleted { get; set; }
        public byte[] IconImg { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string RefId { get; set; }
        public string Erpmodule { get; set; }
        public string MenuCommand { get; set; }
        public string DocType { get; set; }
    }
}
