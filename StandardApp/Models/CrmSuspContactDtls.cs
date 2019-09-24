﻿using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmSuspContactDtls
    {
        public string PksuspContactDtlsId { get; set; }
        public string FksuspectId { get; set; }
        public string ContactName { get; set; }
        public string Designation { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string EmailId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsPrimaryContact { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string ContactPersonDept { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Title { get; set; }
        public string BuyPlan { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string SpouseName { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string MaritalStatus { get; set; }
        public string WhatsAppNo { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
    }
}
