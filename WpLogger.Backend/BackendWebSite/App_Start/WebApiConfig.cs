﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BackendWebSite
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Device",
                routeTemplate: "api/device/{deviceId}",
                defaults: new { controller = "devices", device_id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "App",
                routeTemplate: "api/device/{deviceId}/app/{appId}",
                defaults: new { controller = "apps", appId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Log",
                routeTemplate: "api/device/{deviceId}/app/{appId}/log",
                defaults: new { controller = "logs" }
            );
        }
    }
}
