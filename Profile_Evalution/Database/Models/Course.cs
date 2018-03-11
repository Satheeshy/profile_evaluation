using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Database.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseType { get; set; }
        public string Name { get; set; }

        public int UniversityId { get; set; }
        public virtual IEnumerable<University> Universities { get; set; }

    }
}