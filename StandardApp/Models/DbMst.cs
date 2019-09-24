using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class DbMst
    {
        public decimal RecId { get; set; }
        public string DbMstId { get; set; }
        public string DbName { get; set; }
        public string ServerName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
        public string RptFont { get; set; }
    }
}
