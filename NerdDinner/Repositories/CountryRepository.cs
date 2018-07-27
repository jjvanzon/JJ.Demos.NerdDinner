using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.Repositories
{
    public class CountryRepository : RepositoryBase
    {
        public CountryRepository()
            : base()
        { }

        public CountryRepository(NerdDinnerDataContext context)
            : base(context)
        { }

        public IQueryable<Country> GetAllCountries()
        {
            return Context.Countries;
        }

        public Country GetCountry(int id)
        {
            return Context.Countries.Where(x => x.CountryID == id).Single();
        }

        public Country GetCountry(string name)
        {
            return Context.Countries.Where(x => x.Name == name).Single();
        }
    }
}