using System;
using System.Collections.Generic;

namespace StandardApp.Models
{
    public partial class CrmCssformQuesDtls
    {
        public string PkformQuesDtls { get; set; }
        public string FkformId { get; set; }
        public string FkprimaryQuesId { get; set; }
        public string FksecondaryQuesId { get; set; }
        public string IfResponseId { get; set; }
        public string FkcssFormsQuesId { get; set; }
    }
}
