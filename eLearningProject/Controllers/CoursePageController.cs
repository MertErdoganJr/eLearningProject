using eLearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace eLearningProject.Controllers
{
    public class CoursePageController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index(int p =1)
        {
            var values = context.Courses.ToList().ToPagedList(p, 5);
            return PartialView(values);
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

        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult _CoursePartial()
        {
            var values = context.Courses.Take(6).ToList();
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