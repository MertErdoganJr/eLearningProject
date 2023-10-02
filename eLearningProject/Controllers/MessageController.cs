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
            var values = context.ContactUss.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.ContactUss.Find(id);
            context.ContactUss.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}