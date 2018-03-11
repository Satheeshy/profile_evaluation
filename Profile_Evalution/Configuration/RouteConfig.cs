using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using Autofac.Integration.WebApi;

namespace Profile_Evalution.Configuration
{
    public class RouteConfig
    {
        public static void Register(RouteCollection routeCollection)
        {

            routeCollection.MapMvcAttributeRoutes();
            routeCollection.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routeCollection.MapRoute(
                name: "default",
                url: "{Controller}/{action}/{id}",
                defaults: new { Controller = "Home", action = "Index", id = "" }
                );

           
        }
    }
}