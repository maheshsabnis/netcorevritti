using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class TransTypeList
    {
        public string TransTypeListId { get; set; }
        public string TransCode { get; set; }
        public string CodeDesc { get; set; }
        public decimal? QtyEffect { get; set; }
        public string StatCd { get; set; }
        public bool? ReplicateFlag { get; set; }
    }
}
