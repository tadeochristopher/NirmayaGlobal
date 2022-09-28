using System.Web.Mvc;
using System.Web.Routing;

namespace NirmayaGlobal.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NirmayaGlobal", //Route name...CDW
                url: "{controller}/{action}/{id}", 
                defaults: new { controller = "Site", action = "PortalHome", id = UrlParameter.Optional }, // Parameter defaults
                namespaces: new string[] { "NirmayaGlobal.Controllers" } //Specifying the namespace of our application location controller classes got me around the conflicting URL...CDW
            );
        }
    }
}