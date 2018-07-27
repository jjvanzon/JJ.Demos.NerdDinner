using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.Repositories
{
    public class DinnerRepository : RepositoryBase
    {
        public DinnerRepository()
            : base()
        { }

        public DinnerRepository(NerdDinnerDataContext context)
            : base(context)
        { }

        public IQueryable<Dinner> GetAllDinners()
        {
            return Context.Dinners;
        }

        public IQueryable<Dinner> GetUpcomingDinners()
        {
            return Context.Dinners
                          .Where(x => x.EventDate > DateTime.Now)
                          .OrderBy(x => x.EventDate);
        }

        public Dinner TryGetDinner(int id)
        {
            return Context.Dinners.Where(x => x.DinnerID == id).SingleOrDefault();
        }

        public Dinner GetDinner(int id)
        {
            return Context.Dinners.Where(x => x.DinnerID == id).Single();
        }

        public void Add(Dinner dinner)
        {
            Context.Dinners.InsertOnSubmit(dinner);
        }

        public void Delete(Dinner dinner)
        {
            Context.RSVPs.DeleteAllOnSubmit(dinner.RSVPs);
            Context.Dinners.DeleteOnSubmit(dinner);
        }

        public void Save()
        {
            Context.SubmitChanges();
        }
    }
}