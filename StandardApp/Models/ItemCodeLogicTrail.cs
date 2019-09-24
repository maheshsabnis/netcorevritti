using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemCodeLogicTrail
    {
        public string ItemCodeLogicTrailId { get; set; }
        public string ItemMasterId { get; set; }
        public string OldItemCode { get; set; }
        public string NewItemCode { get; set; }
        public string OldItemDesc { get; set; }
        public string NewItemDesc { get; set; }
        public string Ipaddress { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
