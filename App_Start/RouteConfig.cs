using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Movie_Rental_Management_Web_App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute("MoviesByReleaseDate",
                            "movies/released/{year}/{month}",
                            new { controller = "Movies", action = "ByReleaseDate"},
                            new { year = @"\d{4}", month = @"\d{2}" });
                            //year = @"2015|2016" can constrain year to only be certain values 

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
