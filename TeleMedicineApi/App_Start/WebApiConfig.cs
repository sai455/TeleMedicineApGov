﻿using System.Web.Http;

namespace TeleMedicineApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
