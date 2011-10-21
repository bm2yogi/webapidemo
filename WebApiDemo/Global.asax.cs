using System.ServiceModel.Activation;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.ApplicationServer.Http.Activation;
using WebApiDemo.Apis;

namespace WebApiDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add(new ServiceRoute("contacts", new HttpServiceHostFactory(), typeof(ContactsApi)));
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}