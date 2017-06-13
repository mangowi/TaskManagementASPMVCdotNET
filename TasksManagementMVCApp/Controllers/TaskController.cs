using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementMVCApp.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateEdit()
        {
            return View();
        }
    }
}