using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinner.Resources;
using NerdDinner.Helpers;
using NerdDinner.Validation;
using NerdDinner.Models;
using NerdDinner.Views;
using NerdDinner.ViewModels;
using NerdDinner.Repositories;

namespace NerdDinner.Controllers
{
    public class DinnersController : Controller
    {
        private NerdDinnerDataContext _dataContext;
        private DinnerRepository _dinnerRepository;
        private CountryRepository _countryRepository;

        public DinnersController()
        {
            _dataContext = new NerdDinnerDataContext();
            _dinnerRepository = new DinnerRepository(_dataContext);
            _countryRepository = new CountryRepository(_dataContext);
        }

        // GET: /Dinners/
        // GET: /Dinners/Page/1

        private const int PAGE_SIZE = 5;

        public ViewResult Index(int pageIndex = 0)
        {
            var upcomingDinners = _dinnerRepository.GetUpcomingDinners();

            var page = new Page<Dinner>(upcomingDinners, pageIndex, PAGE_SIZE);

            var dinners = page.Items;

            var viewModel = new DinnersIndexViewModel(dinners, page);
            return View(viewModel);
        }

        // GET: /Dinners/Details/2

        public ViewResult Details(int id)
        {
            Dinner dinner = _dinnerRepository.TryGetDinner(id);
            if (dinner == null)
            {
                return View(ViewNames.NotFound);
            }

            bool modificationIsAuthorized = ModificationIsAuthorized(dinner);
            bool userHasRsvp = dinner.UserHasRsvp(User.Identity.Name);
            var viewModel = new DinnerDetailsViewModel(dinner, modificationIsAuthorized, userHasRsvp);
            return View(viewModel);
        }

        // GET: /Dinners/Create

        [Authorize]
        public ViewResult Create()
        {
            var userName = User.Identity.Name;

            var dinner = new Dinner
            {
                HostedBy = userName,
                EventDate = DateTime.Now.AddDays(7)
            };

            var rsvp = new RSVP
            {
                AttendeeName = userName,
                Dinner = dinner
            };

            DinnerFormViewModel viewModel = CreateFormViewModel(dinner);
            return View(viewModel);
        }

        // POST: /Dinners/Create

        [HttpPost, Authorize]
        public ActionResult Create(DinnerFormViewModel viewModel)
        {
            return Save(viewModel);
        }

        // GET: /Dinners/Edit/2

        [Authorize]
        public ViewResult Edit(int id)
        {
            Dinner dinner = _dinnerRepository.GetDinner(id);

            ViewResult viewResult = ModificationNotAuthorized(dinner);
            if (viewResult != null)
            {
                return viewResult;
            }

            DinnerFormViewModel viewModel = CreateFormViewModel(dinner);
            return View(viewModel);
        }

        // POST: /Dinners/Edit/2

        [HttpPost, Authorize]
        public ActionResult Edit(DinnerFormViewModel viewModel)
        {
            return Save(viewModel);
        }

        // GET: /Dinners/Delete/1
        // POST: /Dinners/Delete/1

        [Authorize]
        public ViewResult Delete(int id)
        {
            switch (Request.HttpMethod)
            {
                case HttpHelper.HttpMethodGet:
                    return DeleteGet(id);

                case HttpHelper.HttpMethodPost:
                    return DeletePost(id);
                
                default:
                    throw new NotSupportedException(String.Format("HttpMethod '{0}' not supported.", Request.HttpMethod));
            }
        }

        private ViewResult DeleteGet(int id)
        {
            Dinner dinner = _dinnerRepository.GetDinner(id);
            if (dinner == null)
            {
                return View(ViewNames.NotFound);
            }

            ViewResult viewResult = ModificationNotAuthorized(dinner);
            if (viewResult != null)
            {
                return viewResult;
            }

            return View(dinner.ToViewModel());
        }

        private ViewResult DeletePost(int id)
        {
            Dinner dinner = _dinnerRepository.TryGetDinner(id);
            if (dinner == null)
            {
                return View(ViewNames.NotFound);
            }

            ViewResult viewResult = ModificationNotAuthorized(dinner);
            if (viewResult != null)
            {
                return viewResult;
            }

            _dinnerRepository.Delete(dinner);
            _dinnerRepository.Save();

            return View(ViewNames.Deleted);
        }

        // Reusable Methods

        private DinnerFormViewModel CreateFormViewModel(Dinner dinner)
        {
            IEnumerable<Country> countries = _countryRepository.GetAllCountries();
            var viewModel = new DinnerFormViewModel(dinner, countries);
            return viewModel;
        }

        private ActionResult Save(DinnerFormViewModel viewModel)
        {
            Dinner dinner = viewModel.Dinner.ToModel(_dataContext);

            ViewResult viewResult = ModificationNotAuthorized(dinner);
            if (viewResult != null)
            {
                return viewResult;
            }

            if (ModelState.IsValid && dinner.IsValid)
            {
                _dinnerRepository.Save();

                return RedirectToAction(ActionNames.Details, new { id = dinner.DinnerID });
            }
            else
            {
                IEnumerable<RuleViolation> ruleViolations = dinner.GetRuleViolations();
                ModelState.AddRuleViolations(ruleViolations);

                DinnerFormViewModel viewModel2 = CreateFormViewModel(dinner);
                return View(viewModel2);
            }
        }

        private ViewResult ModificationNotAuthorized(Dinner dinner)
        {
            if (!ModificationIsAuthorized(dinner))
            {
                var viewModel = new NotAuthorizedViewModel(Messages.OnlyHostCanModify);
                return View(ViewNames.NotAuthorized, viewModel);
            }

            return null;
        }

        private bool ModificationIsAuthorized(Dinner dinner)
        {
            return SecurityHelper.AreUserNamesEqual(dinner.HostedBy, User.Identity.Name);
        }
    }
}