using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Resources;

namespace NerdDinner.Validation
{
    public class RequiredViolation : RuleViolation
    {
        public RequiredViolation(string propertyName)
            : base(String.Format(Messages.Required, propertyName), propertyName)
        { }

        public RequiredViolation(string propertyName, string propertyDisplayName)
            : base(String.Format(Messages.Required, propertyDisplayName), propertyName)
        { }
    }
}