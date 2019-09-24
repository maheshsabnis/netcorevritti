using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class Authentication
    {
        public string AuthenticationId { get; set; }
        public string AccessorType { get; set; }
        public string AccessorId { get; set; }
        public string FunctionId { get; set; }
        public string AccessRole { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
    }
}
