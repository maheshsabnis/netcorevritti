using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ItemSalesGroup
    {
        public string ItemSalesGroupId { get; set; }
        public string ItemSalesGroupCode { get; set; }
        public string ItemSalesGroupName { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
