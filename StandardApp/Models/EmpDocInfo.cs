using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmpDocInfo
    {
        public string EmpDocInfoId { get; set; }
        public string UserMasterId { get; set; }
        public byte[] JoinForm { get; set; }
        public byte[] ChkLst { get; set; }
        public byte[] TrainingSheet { get; set; }
        public byte[] ResumeD { get; set; }
        public byte[] Ssccert { get; set; }
        public byte[] Hssccert { get; set; }
        public byte[] Diploma { get; set; }
        public byte[] Graduation { get; set; }
        public byte[] Pgcert { get; set; }
        public byte[] Aod1 { get; set; }
        public byte[] Aod2 { get; set; }
        public byte[] Aod3 { get; set; }
        public byte[] PhotoId { get; set; }
        public byte[] PermAddPrf { get; set; }
        public byte[] CurrAddPrf { get; set; }
        public byte[] Photo { get; set; }
        public byte[] OfferLetr { get; set; }
        public byte[] IncrmntLetr { get; set; }
        public byte[] SalarySlip1 { get; set; }
        public byte[] SalarySlip2 { get; set; }
        public byte[] SalarySlip3 { get; set; }
        public byte[] ExperienceLetr { get; set; }
        public byte[] RelievingLetr { get; set; }
        public string IsDeleted { get; set; }
        public string IsActive { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }

        public virtual UserMaster UserMaster { get; set; }
    }
}
