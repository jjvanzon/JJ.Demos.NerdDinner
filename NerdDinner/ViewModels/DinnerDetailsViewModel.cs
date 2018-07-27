using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public class DinnerDetailsViewModel
    {
        public DinnerDetailsViewModel(Dinner dinner, bool modificationIsAllowed, bool userHasRsvp)
        {
            Dinner = dinner.ToViewModel();
            ModificationIsAllowed = modificationIsAllowed;
            UserHasRsvp = userHasRsvp;
        }

        public DinnerViewModel Dinner {get; private set;}
        public bool ModificationIsAllowed { get; private set; }
        public bool UserHasRsvp { get; private set; }
    }
}