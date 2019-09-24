using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Vskeys
    {
        public decimal RecId { get; set; }
        public string TypeCode { get; set; }
        public string CodeId { get; set; }
        public string CodeDesc { get; set; }
        public string LongDesc { get; set; }
        public string Fixed { get; set; }
        public string IsDeleted { get; set; }
    }
}
