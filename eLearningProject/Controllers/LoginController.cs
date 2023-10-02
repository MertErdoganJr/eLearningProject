using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;

namespace eLearningProject.Controllers
{
    public class LoginController : Controller
    {

        eLearningContext context = new eLearningContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student, Admin admin)
        {
            var values1 = context.Students.FirstOrDefault(x => x.Email == student.Email && x.Password == student.Password);
            var values2 = context.Admins.FirstOrDefault(x => x.Email == admin.Email && x.Password == admin.Password);
            if (values1 != null)
            {
                FormsAuthentication.SetAuthCookie(values1.Email, false);
                Session["CurrentMail"] = values1.Email;
                Session.Timeout = 60;
                return RedirectToAction("Index", "Profile");
            }

            if(values2 != null)
            {
                FormsAuthentication.SetAuthCookie(values2.Email, false);
                Session["CurrentMail"] = values2.Email;
                Session.Timeout = 60;
                return RedirectToAction("Index", "AdminDashboard");
            }
            return View();
        }
    }
}