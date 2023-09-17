using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class CourseController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            
            var values = context.Courses.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}