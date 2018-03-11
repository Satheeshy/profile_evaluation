using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Profile_Evalution.Database.Context;
using Profile_Evalution.Database.Models;
using Profile_Evalution.Services;
using Profile_Evalution.Services.IdentityService;
using Profile_Evalution.Services.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Profile_Evalution.Configuration
{
    public class AutofacConfig
    {

        public static IContainer Configure()
        {
            var container = new ContainerBuilder();


          

            container.RegisterType<ApplicationDBContext>().InstancePerRequest();

            container.RegisterType<ApplicationUserStore>().As<IUserStore<AppUser>>();
            container.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();

            container.Register<IAuthenticationManager>(context => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();

            container.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            container.RegisterApiControllers(Assembly.GetExecutingAssembly());

            container.RegisterType<JWTHandler>().AsSelf().InstancePerRequest();
            return container.Build();
        }
    }
}