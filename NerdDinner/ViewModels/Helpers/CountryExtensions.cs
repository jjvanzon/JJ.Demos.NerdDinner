using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public static class CountryExtensions
	{
        public static CountryViewModel ToViewModel(this Country country)
        {
            return new CountryViewModel
            {
                CountryID = country.CountryID,
                Name = country.Name
            };
        }
	}
}