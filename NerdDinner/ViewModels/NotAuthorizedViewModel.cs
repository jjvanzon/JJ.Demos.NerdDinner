using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.ViewModels
{
    public class NotAuthorizedViewModel
    {
        public NotAuthorizedViewModel(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}