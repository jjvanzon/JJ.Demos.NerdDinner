using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using NerdDinner.Repositories;
using NerdDinner.Models;

namespace NerdDinner.Validation
{
    public static class PhoneNumberValidator
    {
        public static bool PhoneNumberIsValid(string phoneNumber, Country country)
        {
            if (country == null)
            {
                throw new ArgumentNullException("country");
            }

            if (country.PhoneNumberRegex == null)
            {
                return true;
            }

            return country.PhoneNumberRegex.IsMatch(phoneNumber);
        }
    }
}