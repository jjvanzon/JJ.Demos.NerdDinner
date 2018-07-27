using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public static class IEnumerableOfCountryExtensions
    {
        public static IEnumerable<CountryViewModel> ToViewModel(this IEnumerable<Country> list)
        {
            return list.Select(x => x.ToViewModel());
        }
    }
}