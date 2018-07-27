using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Resources;

namespace NerdDinner.Validation
{
    public static class RuleHelper
    {
        public static string GetRequiredMessage(string fieldName)
        {
            return String.Format(Messages.Required, fieldName);
        }
    }
}