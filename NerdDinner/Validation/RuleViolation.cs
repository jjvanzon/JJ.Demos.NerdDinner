using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Validation
{
    public class RuleViolation
    {
        public string ErrorMessage { get; private set; }
        public string PropertyName { get; private set; }

        public RuleViolation(string errorMessage, string propertyName)
        {
            ErrorMessage = errorMessage;
            PropertyName = propertyName;
        }
    }
}