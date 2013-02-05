using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc4BaseApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //I don't want the HomeController urls to be shown as "{domain}/Home/Action".
            //This also fixes an issue with the mvc bootstrap's extension methods: the terms "Home" and "Index" are ignored when the navigation bar links are build.
            routes.MapRoute("HomeActions","{action}", new {controller = "Home", action = "Index"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}