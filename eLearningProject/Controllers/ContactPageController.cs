using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class ContactPageController : Controller
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

        public PartialViewResult _HeaderPartial()
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

        [HttpGet]
        public ActionResult _ContactPartial()
        {
            
            return PartialView();
        }

        [HttpPost]
        public ActionResult _ContactPartial(ContactUs contactUs)
        {
            context.ContactUss.Add(contactUs);
            context.SaveChanges();
            return PartialView();
        }
    }
}