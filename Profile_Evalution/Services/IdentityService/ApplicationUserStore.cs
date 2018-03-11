using Microsoft.AspNet.Identity.EntityFramework;
using Profile_Evalution.Database.Context;
using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Services.IdentityService
{
    public class ApplicationUserStore : UserStore<AppUser>
    {
        public ApplicationUserStore(ApplicationDBContext context) : 
            
            
            base(context)
        {
        }
    }
}