using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using NerdDinner.Resources;
using NerdDinner.Validation;
using System.Web.Mvc;
using NerdDinner.Helpers;

namespace NerdDinner.Models
{
    public partial class Dinner
    {
        public bool IsValid
        {
            get { return GetRuleViolations().Count() == 0; }
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            List<RuleViolation> list = new List<RuleViolation>();

            if (String.IsNullOrEmpty(Title))
            {
                list.Add(new RequiredViolation(PropertyNames.Title, PropertyDisplayNames.Title));
            }

            if (String.IsNullOrEmpty(Description))
            {
                list.Add(new RequiredViolation(PropertyNames.Description, PropertyDisplayNames.Description));
            }

            if (String.IsNullOrEmpty(HostedBy))
            {
                list.Add(new RequiredViolation(PropertyNames.HostedBy, PropertyDisplayNames.HostedBy));
            }

            if (String.IsNullOrEmpty(Address))
            {
                list.Add(new RequiredViolation(PropertyNames.Address, PropertyDisplayNames.Address));
            }

            if (Country == null)
            {
                list.Add(new RequiredViolation(PropertyNames.Country, PropertyDisplayNames.Country));
            }

            if (String.IsNullOrEmpty(ContactPhone))
            {
                list.Add(new RequiredViolation(PropertyNames.ContactPhone, PropertyDisplayNames.ContactPhone));
            }

            if (Country != null)
            {
                if (!PhoneNumberValidator.PhoneNumberIsValid(ContactPhone, Country))
                {
                    list.Add(new RuleViolation(Messages.PhoneAndCountryDoNotMatch, PropertyNames.ContactPhone));
                }
            }

            return list;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
            {
                throw new ApplicationException("Rule violations prevent saving.");
            }
        }

        public bool UserHasRsvp(string userName)
        {
            return RSVPs.Any(x => SecurityHelper.AreUserNamesEqual(x.AttendeeName, userName));
        }
    }
}
