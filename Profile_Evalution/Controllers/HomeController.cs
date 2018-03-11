using Microsoft.Owin.Security;
using Profile_Evalution.Services.IdentityService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Profile_Evalution.Controllers
{
    [Route("home")]
    public class HomeController: ApiController
    {

        public HomeController(ApplicationUserManager userManager,ApplicationSignInManager signInManager,IAuthenticationManager authManager) {
            UserManager = userManager;
            SignInManager = signInManager;
            AuthManager = authManager;
        }

        private readonly ApplicationUserManager UserManager;
        private readonly ApplicationSignInManager SignInManager;
        private readonly IAuthenticationManager AuthManager;

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}