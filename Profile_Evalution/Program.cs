using Microsoft.Owin;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Owin;
using Profile_Evalution.Configuration;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Profile_Evalution.Startup))]
namespace Profile_Evalution
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // MVC routes configuration
            //RouteConfig.Register(RouteTable.Routes);
           
            var httpConfig = GlobalConfiguration.Configuration;

            //Autofac middleware
            var container = AutofacConfig.Configure();
            app.UseAutofacMiddleware(container);
            
            //Autofac for api routes
            WebConfig.Register(httpConfig);
            //GlobalConfiguration.Configure(WebConfig.Configure);
            httpConfig.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            app.UseAutofacWebApi(httpConfig);
            //now we are running on top of iis
            //Tomorrow we can use own self hosting owin
            app.UseWebApi(httpConfig);




            //GlobalConfiguration.Configure(WebConfig.Register);
            //// FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.Register(RouteTable.Routes);


        }
    }
}