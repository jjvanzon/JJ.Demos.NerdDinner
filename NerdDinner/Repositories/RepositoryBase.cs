using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;

namespace NerdDinner.Repositories
{
    public class RepositoryBase
    {
        public RepositoryBase()
            : this(new NerdDinnerDataContext())
        { }

        public RepositoryBase(NerdDinnerDataContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            _context = context;
        }

        private NerdDinnerDataContext _context;

        protected NerdDinnerDataContext Context
        {
            get { return _context; }
        }   
    }
}