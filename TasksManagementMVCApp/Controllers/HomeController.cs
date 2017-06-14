using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Survey()
        {
            return PartialView();
        }

        public ActionResult Suggestion()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Suggestion(string suggestion)
        {
            if (!string.IsNullOrWhiteSpace(suggestion))
            {
                TempData["Status"] = "Your message has been submitted";
            }
            else
            {
                TempData["Status"] = "Your message has not been submitted";
            }
            return RedirectToAction("index");

        }
    
    }
}