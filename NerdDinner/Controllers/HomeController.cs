using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerdDinner.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["Message"] = "Welcome to NerdDinner!";

            return View();
        }

        public ViewResult About()
        {
            return View();
        }
    }
}
