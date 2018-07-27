using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NerdDinner.Controllers;

namespace NerdDinner
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                RouteNames.UpcomingDinners,
                "Dinners/Page/{pageIndex}",
                new 
                { 
                    controller = ControllerNames.Dinners, 
                    action = ActionNames.Index,
                    pageIndex = 0
                });

            routes.MapRoute(
                RouteNames.Default,
                // URL with parameters
                "{controller}/{action}/{id}",
                // Parameter defaults
                new 
                {
                    controller = ControllerNames.Home, 
                    action = ActionNames.Index, 
                    id = UrlParameter.Optional 
                });
        }
    }
}