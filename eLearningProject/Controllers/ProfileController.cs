using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;
using Microsoft.Ajax.Utilities;

namespace eLearningProject.Controllers
{
    public class ProfileController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            var values = Session["CurrentMail"].ToString();
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x => x.Email == values).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            return View();
        }

        public ActionResult MyCourseList()
        {
            string values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            return View(courseList);
        }
        public PartialViewResult CourseListByStudentProfile()
        {
            string values = Session["CurrentMail"].ToString();
            int id = context.Students.Where(x => x.Email == values).Select(y => y.StudentID).FirstOrDefault();
            var courseList = context.Processes.Where(x => x.StudentID == id).ToList();
            return PartialView(courseList);
        }

        public ActionResult WatchCourse()
        {
            var values = context.Courses.Take(1).ToList();
            return View(values);
        }

    }
}