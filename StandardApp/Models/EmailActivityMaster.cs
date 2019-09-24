using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class EmailActivityMaster
    {
        public string PkactViaEmailId { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public string ActivityCreation { get; set; }
        public string ConnString { get; set; }
        public string TableName { get; set; }
        public string IsFtppath { get; set; }
        public string Popserver { get; set; }
        public bool? UseLocalfolder { get; set; }
        public string Ftpserver { get; set; }
        public string FolderPath { get; set; }
        public string WorkSpaceId { get; set; }
        public string MainGrpId { get; set; }
        public string SubGrpId { get; set; }
        public string NatureOfWorkId { get; set; }
        public string Priority { get; set; }
        public string ActivityName { get; set; }
        public string IssuedTo { get; set; }
        public string NoofdaysToComplete { get; set; }
        public string IsIntimatecompletion { get; set; }
        public bool? IsApprovalRequired { get; set; }
        public string ForwardEmailTo { get; set; }
        public string SourceType { get; set; }
        public string SourceId { get; set; }
        public string IsDeleted { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public decimal? HoursRequired { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserMasterId { get; set; }
        public string CreateAsTicket { get; set; }
        public string AssignAddrTo { get; set; }
    }
}
