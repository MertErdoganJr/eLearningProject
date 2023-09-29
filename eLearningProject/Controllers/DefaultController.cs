using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;
using Newtonsoft.Json.Linq;

namespace eLearningProject.Controllers
{
    public class DefaultController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult _SpinnerPartial()
        {
            return PartialView();
        }

        public PartialViewResult _NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _CarouselPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ServicePartial()
        {
            return PartialView();
        }
        public PartialViewResult _AboutPartial()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);

        }
        public PartialViewResult _CategoryPartial()
        {

            var values = context.Courses.ToList();

            ViewBag.c1 = context.Courses.Where(x=>x.CourseID == 1).Select(y=>y.Title).FirstOrDefault();
            ViewBag.c2 = context.Courses.Where(x=>x.CourseID == 2).Select(y=>y.Title).FirstOrDefault();
            ViewBag.c3 = context.Courses.Where(x=>x.CourseID == 3).Select(y=>y.Title).FirstOrDefault();
            ViewBag.c4 = context.Courses.Where(x=>x.CourseID == 4).Select(y=>y.Title).FirstOrDefault();

            return PartialView(values);
        }

        public PartialViewResult _CoursesPartial()
        {
            var values = context.Courses.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult _TeamPartial()
        {
            var values = context.Instructors.ToList();
            return PartialView(values);
        }
        public PartialViewResult _TestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }

    }
}