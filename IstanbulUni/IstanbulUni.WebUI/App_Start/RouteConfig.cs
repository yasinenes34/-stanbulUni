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

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                   name: "Login",
                   url: "login",
                   defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                  name: "Logout",
                  url: "logout",
                  defaults: new { controller = "User", action = "Logout", id = UrlParameter.Optional }
              );

            //routes.MapRoute(
            //      name: "Student",
            //      url: "Student",
            //      defaults: new { controller = "Student", action = "StudentList", id = UrlParameter.Optional }
            //  );


            //routes.MapRoute(
            //    name: "Index",
            //    url: "studentIndex",
            //    defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
            //);
            // routes.MapRoute(
            //    name: "StudentAdd",
            //    url: "studentadd",
            //    defaults: new { controller = "Student", action = "StudentAdd", id = UrlParameter.Optional }
            //);
           // routes.MapRoute(
           //    name: "StudentUpdate",
           //    url: "UpdateStudent/{id}",
           //    defaults: new { controller = "Student", action = "StudentUpdate", id = UrlParameter.Optional }
           //);







        }
    }
}
