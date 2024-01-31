using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCourse.Models;

namespace WebAppCourse.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
              {
        new Course(){Id=1,Name="Manju",Fee=25000,Technology="ASP",CStartDate=new DateTime(day:23,month:06,year:2022),CEndDate=new DateTime(day:30,month:09,year:2022)},
        new Course(){Id=2,Name="Sanju",Fee=25000,Technology="Javascript",CStartDate=new DateTime(day:23,month:07,year:2022),CEndDate=new DateTime(day:30,month:10,year:2022)},
        new Course(){Id=3,Name="Swetha",Fee=25000,Technology="python",CStartDate=new DateTime(day:23,month:08,year:2022),CEndDate=new DateTime(day:30,month:11,year:2022)},
    };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }
        [HttpPost]
        public ActionResult Create(Course C)
        {
            if (ModelState.IsValid)
            {
                courses.Add(C);
                return RedirectToAction("Index");
            }
            return View(C);
        }
    }
}

