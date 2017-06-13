using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TasksManagementMVCApp.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Messages
        public ActionResult VieAll()
        {
            return View();
        }

        public ActionResult Reply()
        {
            return View();
        }
    }
}