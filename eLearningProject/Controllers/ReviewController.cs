using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class ReviewController : Controller
    {
        eLearningContext context = new eLearningContext();

        [HttpGet]
        public ActionResult Index()
        {
            
            var values = context.Courses.ToList();
            List<SelectListItem> courseList = (from x in values
                                               select new SelectListItem
                                               {
                                                   Text = x.Title,
                                                   Value = x.CourseID.ToString(),
                                               }).ToList();
            ViewBag.course = courseList;
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(Review review)
        {
            var email = Session["CurrentMail"];
            
            var studentID = context.Students.Where(x => x.Email == email.ToString()).Select(x => x.StudentID).FirstOrDefault();
            review.StudentID = studentID;
            context.Reviews.Add(review);

            context.SaveChanges();
            return RedirectToAction("Index", "Profile");
        }

    }
}