using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Models;
using NerdDinner.Repositories;
using NerdDinner.Resources;

namespace NerdDinner.Controllers
{
    public class RsvpController : Controller
    {
        private NerdDinnerDataContext _dataContext;
        private DinnerRepository _dinnerRepository;

        public RsvpController()
        {
            _dataContext = new NerdDinnerDataContext();
            _dinnerRepository = new DinnerRepository(_dataContext);
        }

        // AJAX: /Dinners/Rsvp/1

        [Authorize, HttpPost]
        public ContentResult Rsvp(int dinnerID)
        {
            Dinner dinner = _dinnerRepository.GetDinner(dinnerID);

            string userName = User.Identity.Name;

            if (!dinner.UserHasRsvp(userName))
            {
                var rsvp = new RSVP
                {
                    AttendeeName = userName
                };

                dinner.RSVPs.Add(rsvp);
                _dinnerRepository.Save();
            }

            return Content(Messages.RsvpConfirmation);
        }
    }
}
