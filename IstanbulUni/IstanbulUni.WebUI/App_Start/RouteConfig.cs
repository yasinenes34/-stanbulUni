using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IstanbulUni.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
           
            routes.MapRoute(
                   name: "Login",
                   url: "",
                   defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                  name: "Register",
                  url: "register",
                  defaults: new { controller = "User", action = "Register", id = UrlParameter.Optional }
              );
           

            routes.MapRoute(
                name: "Index",
                url: "studentIndex",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "StudentAdd",
               url: "studentadd",
               defaults: new { controller = "Student", action = "StudentAdd", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "StudentUpdate",
               url: "studentadd",
               defaults: new { controller = "Student", action = "StudentAdd", id = UrlParameter.Optional }
           );







        }
    }
}
