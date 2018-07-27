using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace NerdDinner.Models
{
    public partial class Country
    {
        partial void OnCreated()
        {
            InitializePhoneNumberRegex();
        }

        private Regex _phoneNumberRegex;

        public Regex PhoneNumberRegex
        {
            get { return _phoneNumberRegex; }
        }

        private void InitializePhoneNumberRegex()
        {
            if (PhoneNumberPattern != null)
            {
                _phoneNumberRegex = new Regex(PhoneNumberPattern);
            }
        }
    }
}