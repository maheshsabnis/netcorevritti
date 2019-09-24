using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssformsQuestns
    {
        public string PkcssFormsQuesId { get; set; }
        public string FkquesId { get; set; }
        public int? Weightage { get; set; }
        public string IsResponseMandatory { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public string IsDeleted { get; set; }
        public string FkCssFormsId { get; set; }
        public int? SequenceNo { get; set; }
        public string ExpectedResponse { get; set; }
        public string IsBranching { get; set; }
        public string IfResponseId { get; set; }
        public string DisableQuesStr { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int? MaxNoOfResponses { get; set; }
        public string MaxExpectedResponse { get; set; }
        public string ResponseType { get; set; }
    }
}
