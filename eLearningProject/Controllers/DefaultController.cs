using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;

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
            return PartialView();
        }

        public PartialViewResult _CoursesPartial()
        {
            return PartialView();
        }
        public PartialViewResult _TeamPartial()
        {
            return PartialView();
        }
        public PartialViewResult _TestimonialPartial()
        {
            return PartialView();
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