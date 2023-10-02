using eLearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class AdminDashboardController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            var values1 = Session["CurrentMail"].ToString();
            var values  = context.Admins.ToList();
            return View(values);
        }
    }
}