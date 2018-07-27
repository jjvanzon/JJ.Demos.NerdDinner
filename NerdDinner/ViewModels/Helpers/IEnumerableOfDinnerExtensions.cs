using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public static class IEnumerableOfDinnerExtensions
    {
        public static IEnumerable<DinnerViewModel> ToViewModel(this IEnumerable<Dinner> list)
        {
            return list.Select(x => x.ToViewModel());
        }
    }
}