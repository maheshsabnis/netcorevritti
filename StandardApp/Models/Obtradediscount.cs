using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Obtradediscount
    {
        public string ObtradediscountId { get; set; }
        public string CustVendorMasterId { get; set; }
        public string ItemMasterId { get; set; }
        public string TypeFixedPercent { get; set; }
        public DateTime? Validfrom { get; set; }
        public DateTime? Validto { get; set; }
        public string DisRate { get; set; }
        public string NetRate { get; set; }
        public int? CouponId { get; set; }
        public string Freeitemid { get; set; }
        public decimal? Freeitemqty { get; set; }
        public decimal? Minqty { get; set; }
        public string Discratepercent { get; set; }
        public string DiscrateMrp { get; set; }
        public decimal? Minvalue { get; set; }
        public string Vendoritemname { get; set; }
        public decimal? Price { get; set; }
    }
}
