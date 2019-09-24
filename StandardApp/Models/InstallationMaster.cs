using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class InstallationMaster
    {
        public decimal InstalationId { get; set; }
        public string InstalationName { get; set; }
        public string Address { get; set; }
        public string ContactPersoneName { get; set; }
        public string ContactPhone { get; set; }
        public string SupportEngName { get; set; }
        public string SupportEngPhone { get; set; }
        public string MasterDbname { get; set; }
        public string TransactionDbname { get; set; }
        public string SupportPhone { get; set; }
        public string InstallationDesc { get; set; }
        public decimal? StationMasterId { get; set; }
        public decimal? Csid { get; set; }
        public string NetworkCode { get; set; }
        public string SubnetworkCode { get; set; }
        public string Tvcount { get; set; }
        public string StationStatus { get; set; }
        public string Category { get; set; }
    }
}
