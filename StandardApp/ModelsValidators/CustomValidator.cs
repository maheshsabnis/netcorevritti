using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// the namespace for validators attribute classes
using System.ComponentModel.DataAnnotations; 

namespace StandardApp.ModelsValidators
{
    public class LengthValidatorAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString().Length > 15) return false;
            return true;
        }
    }
   
}
