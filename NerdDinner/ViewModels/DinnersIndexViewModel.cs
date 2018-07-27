using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdDinner.Helpers;
using NerdDinner.Models;

namespace NerdDinner.ViewModels
{
    public class DinnersIndexViewModel
    {
        public DinnersIndexViewModel(IEnumerable<Dinner> items, Pager pager)
        {
            if (items == null) throw new ArgumentNullException("items");
            if (pager == null) throw new ArgumentNullException("pager");
            Items = items.ToViewModel();
            Pager = pager;
        }

        public IEnumerable<DinnerViewModel> Items { get; private set; }
        public Pager Pager { get; private set; }
    }
}
