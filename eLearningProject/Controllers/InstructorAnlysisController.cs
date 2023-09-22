﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;

namespace eLearningProject.Controllers
{
    public class InstructorAnlysisController : Controller
    {
        eLearningContext context = new eLearningContext();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult InstructorPanelPartial()
        {
            int id = 1;
            var values = context.Instructors.Where(x => x.InstructorID == id).ToList();
            return PartialView(values);
        }

        public PartialViewResult CommetPartial()
        {

            var v1 = context.Instructors.Where(x => x.Name == "Ahmet" && x.Surname == "Ölçen").Select(y => y.InstructorID).FirstOrDefault();
            var v2 = context.Courses.Where(x => x.InstructorID == v1).Select(y => y.CourseID).ToList();
            var v3 = context.Comments.Where(x=>v2.Contains(x.CourseID)).ToList();

            return PartialView(v3);
        }
    }
}