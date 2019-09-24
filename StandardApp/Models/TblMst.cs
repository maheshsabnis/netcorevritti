using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TblMst
    {
        public decimal RecId { get; set; }
        public string TblMstId { get; set; }
        public string TblName { get; set; }
        public string TblDesc { get; set; }
        public string DbmstId { get; set; }
        public string TblType { get; set; }
    }
}
