using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile_Evalution.RestAPI.models
{
    public class ApiRegister
    {
        public string UserName { get; set; }
        public string  Email { get; set; }
        public string Password { get; set; }
        public string CountryOfResidence { get; set; }
        public string PhoneNumber { get; set; }
    }
}