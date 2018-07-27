using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Helpers
{
    public static class SecurityHelper
    {
        public static bool AreUserNamesEqual(string userName1, string userName2)
        {
            // Ingore case in case you migrate to Active Directory?
            return String.Equals(userName1, userName2, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}