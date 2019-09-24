using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrtnProdHeader
    {
        public string CrtnProdHeaderId { get; set; }
        public string RecType { get; set; }
        public string CrtnProdNo { get; set; }
        public DateTime? CrtnProdDt { get; set; }
        public string RefType { get; set; }
        public string RefId { get; set; }
        public string StatusId { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
