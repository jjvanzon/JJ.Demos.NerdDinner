using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public class DinnerFormViewModel
    {
        public DinnerViewModel Dinner { get; private set; }
        public CountryViewModel[] Countries { get; private set; }

        /// <summary>
        /// Required for use as postback data.
        /// </summary>
        public DinnerFormViewModel()
            : this(null, null)
        { }

        public DinnerFormViewModel(Dinner dinner, IEnumerable<Country> countries)
        {
            Dinner = dinner != null ? dinner.ToViewModel() : new DinnerViewModel();
            Countries = countries != null ? countries.ToViewModel().ToArray() : new CountryViewModel[0];
        }
    }
}