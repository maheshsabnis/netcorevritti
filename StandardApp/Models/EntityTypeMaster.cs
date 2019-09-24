using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EntityTypeMaster
    {
        public string EntityTypeMasterId { get; set; }
        public string EntityTypeCode { get; set; }
        public string EntityType { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string PriceListClassificationId { get; set; }
        public string Entity { get; set; }
        public string EntityAs { get; set; }
        public string IsPartner { get; set; }
        public string AccountMasterId { get; set; }
    }
}
