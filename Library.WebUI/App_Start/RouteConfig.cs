﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Library.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "BookList",
                url: "books",
                defaults: new { controller = "Books", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AddBook",
                url: "books/Add",
                defaults: new { controller = "Books", action = "Add", id = UrlParameter.Optional }
            );


        }
    }
}
