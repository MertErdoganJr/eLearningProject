using eLearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class AboutPageController : Controller
    {
        eLearningContext context  = new eLearningContext();
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

        public PartialViewResult _HeaderPartial()
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