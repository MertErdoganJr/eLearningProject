using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eLearningProject.DAL.Context;

namespace eLearningProject.Controllers
{
    public class InstructorAnlysisController : Controller
    {
        eLearningContext context = new eLearningContext();
        
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult InstructorPanelPartial(int id)
        {
            id = 1;
            var values = context.Instructors.Where(x=>x.InstructorID == id).ToList();
            return PartialView(values);
        }
    }
}