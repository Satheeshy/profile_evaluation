using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Profile_Evalution.Database.Models
{
    public class UniversityScore
    {
        [Key]
        [Column(Order =0)]
        public int CourseId { get; set; }
        [Key]
        [Column(Order =1)]
        public int SchoolId { get; set; }

        public decimal GRE { get; set; }
        public decimal IELTS { get; set; }
        public decimal TOEFL { get; set; }
        public decimal GMAT { get; set; }
        public decimal SAT { get; set; }
        public decimal GradPercentage { get; set; }
        public decimal UnderGradPercentage { get; set; }





    }
}