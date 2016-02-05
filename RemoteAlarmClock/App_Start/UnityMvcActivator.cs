using System.Linq;
using System.Web.Mvc;
using System.Web.Http;
using Microsoft.Practices.Unity.WebApi;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(RemoteAlarmClock.Web.Web.App_Start.UnityWebActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(RemoteAlarmClock.Web.Web.App_Start.UnityWebActivator), "Shutdown")]

namespace RemoteAlarmClock.Web.Web.App_Start
{
    /// <summary>Provides the bootstrapping for integrating Unity with ASP.NET MVC.</summary>
    public static class UnityWebActivator
    {
        /// <summary>Integrates Unity when the application starts.</summary>
        public static void Start() 
        {
            var resolver = new UnityDependencyResolver(UnityConfig.GetConfiguredContainer());

            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        /// <summary>Disposes the Unity container when the application is shut down.</summary>
        public static void Shutdown()
        {
            var container = UnityConfig.GetConfiguredContainer();
            container.Dispose();
        }
    }
}