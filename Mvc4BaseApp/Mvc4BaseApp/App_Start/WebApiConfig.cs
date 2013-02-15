using Castle.Windsor;
using Mvc4BaseApp.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace Mvc4BaseApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IWindsorContainer container)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var httpControllerActivator = new WindsorCompositionRoot(container);

            config.Services.Replace(typeof(IHttpControllerActivator), httpControllerActivator);
        }
    }
}
