using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;

namespace eLearningProject.Controllers
{
    public class ProfileController : Controller
    {
        eLearningContext context =new eLearningContext();
        public ActionResult Index()
        {
            var values  = Session["CurrentMail"].ToString();
            ViewBag.mail = Session["CurrentMail"];
            ViewBag.name = context.Students.Where(x=>x.Email == values).Select(y=>y.Name + " " + y.Surname).FirstOrDefault();
            return View();
        }

        public ActionResult MyCourseList()
        {

            return View();
        }
    }
}