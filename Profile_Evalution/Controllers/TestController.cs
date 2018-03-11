using Profile_Evalution.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Profile_Evalution.Controllers 
{
    public class TestController : ApiController
    {
        private ApplicationDBContext context { get; set; }

        public TestController(ApplicationDBContext db){ this.context = db;}


        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "hello");
        }
        }
    
}