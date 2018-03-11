using Profile_Evalution.Database.Models;
using Profile_Evalution.RestAPI.models;
using Profile_Evalution.Services.IdentityService;
using Profile_Evalution.Services.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Profile_Evalution.RestAPI
{

    public class AuthController : ApiController
    {
        private readonly ApplicationUserManager userManager;
        private readonly ApplicationSignInManager signInManager;
        private readonly JWTHandler jwt;

        public AuthController(ApplicationUserManager userManager,ApplicationSignInManager signInManager,JWTHandler jwt)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.jwt = jwt;
        }
        [HttpPost]
        public async Task<HttpResponseMessage> Login([FromBody] ApiLogin login )
        {
            if (login == null || !ModelState.IsValid) return Request.CreateResponse(HttpStatusCode.BadRequest, "Login Details are not valid");

            var user = await userManager.FindAsync(login.Username, login.Password);

            if (user == null) return Request.CreateResponse(HttpStatusCode.Unauthorized,"Username or Password is invalid");

            string token = jwt.GenerateTokenForUser(user.UserName, user.Id);

            return Request.CreateResponse(HttpStatusCode.Accepted,token);
            
        }

        //public async Task<HttpResponseMessage> Register([FromBody] ApiRegister register)
        //{
        //    if (register == null || !ModelState.IsValid) return Request.CreateResponse(HttpStatusCode.BadRequest, "Register Details are not valid");

        //    var appUser = new AppUser
        //    {
        //        UserName = register.UserName,
        //        Email = register.Email,
        //        PasswordHash = register.Password,
        //        PhoneNumber = register.PhoneNumber,
        //        CountryOfResidence = register.CountryOfResidence
        //    };

        //    userManager.cre

        //}
        



    }
}