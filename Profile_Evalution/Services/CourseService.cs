using Profile_Evalution.Database.Context;
using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Services
{
    public class CourseService : CrudService<int, Course>
    {
        public CourseService(ApplicationDBContext context) : base(context)
        {
        }
    }
}