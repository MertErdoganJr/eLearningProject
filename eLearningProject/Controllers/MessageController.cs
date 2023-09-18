using eLearningProject.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class MessageController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            return View();
        }
    }
}