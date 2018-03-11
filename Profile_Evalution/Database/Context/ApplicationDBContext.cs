using Microsoft.AspNet.Identity.EntityFramework;
using Profile_Evalution.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Database.Context
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext() { }
        public ApplicationDBContext(string connectionString = "ProfileEvaluation") :base(connectionString) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<UniversityScore> UniversityScores { get; set; }
    }
}