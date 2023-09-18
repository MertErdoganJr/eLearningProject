using eLearningProject.DAL.Context;
using eLearningProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eLearningProject.Controllers
{
    public class AboutController : Controller
    {
        eLearningContext context = new eLearningContext();
        public ActionResult Index()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.Abouts.Find(about.AboutID);
            value.Title = about.Title;
            value.Description = about.Description;
            value.Skill1 = about.Skill1;
            value.Skill2 = about.Skill2;
            value.Skill3 = about.Skill3;
            value.Skill4 = about.Skill4;
            value.Skill5 = about.Skill5;
            value.Skill6 = about.Skill6;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}