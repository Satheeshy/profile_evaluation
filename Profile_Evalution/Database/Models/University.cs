using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Database.Models
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }

        public int CourseId { get; set; }
        public virtual IEnumerable<Course> Courses { get; set; }
    }
}