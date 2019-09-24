using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class ApplicationSetUp
    {
        public string PkappSetUpId { get; set; }
        public decimal? PassMinLength { get; set; }
        public decimal? PassMaxLength { get; set; }
        public string PassCharacters { get; set; }
        public decimal? ChangePassDays { get; set; }
        public decimal? LstPassCount { get; set; }
        public decimal? DisableAccWrongPass { get; set; }
        public bool? Mail { get; set; }
        public decimal? DisableAccNotLog { get; set; }
        public bool? Vowels { get; set; }
        public bool? ChangePass1stLogin { get; set; }
        public bool? SystenGenMail { get; set; }
        public decimal? CreationLevel { get; set; }
        public decimal? UserLevel { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public bool? TaskHistory { get; set; }
        public string PhotoType { get; set; }
        public string Photosize { get; set; }
        public bool? ShowPhotoOnAllPages { get; set; }
        public string AdnimMail { get; set; }
        public string IsMaxGroupRights { get; set; }
        public string BranchNameAs { get; set; }
        public string IsUserMailCompl { get; set; }
    }
}
