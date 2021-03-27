using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Enabling Attribute Routing
            routes.MapMvcAttributeRoutes();

            // Ctrl+K Ctrl+C  =  comment out code
            // Ctrl+K Ctrl+U = Uncomment code
            //routes.MapRoute(
            //    "MoviesByReleasDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"2015|2016", month = @"\d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
