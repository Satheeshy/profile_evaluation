using Profile_Evalution.Database.Context;
using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Services
{
    public class UniversityScoreService : CrudService<int, UniversityScore>
    {
        public UniversityScoreService(ApplicationDBContext context) : base(context)
        {
        }
    }
}