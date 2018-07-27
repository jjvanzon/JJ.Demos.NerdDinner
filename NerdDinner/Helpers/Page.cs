using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Resources;
using System.Collections;

namespace NerdDinner.Helpers
{
    public class Page<T> : Pager
    {
        private IEnumerable<T> _source;

        public Page(IEnumerable<T> source, int pageIndex, int pageSize)
            : base(source.Count(), pageIndex, pageSize)
        {
            _source = source;
        }

        public IEnumerable<T> Items
        {
            get { return _source.Skip(FirstIndex).Take(PageSize); }
        }
   }
}