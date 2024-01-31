using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCourse.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public double Fee { get; set; }
        public string Technology { get; set; }
        public DateTime CStartDate { get; set; }
        public DateTime CEndDate { get; set; }


    }
}