using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Validation;

namespace NerdDinner.Controllers
{
	public static class ModelStateDictionaryExtensions
	{
        public static void AddRuleViolations(this ModelStateDictionary modelState, IEnumerable<RuleViolation> ruleviolations)
        {
            foreach (RuleViolation x in ruleviolations)
            {
                modelState.AddModelError(x.PropertyName, x.ErrorMessage);
            }
        }
	}
}