using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAssignment.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Services()
        {
            return View();
        }
    }
}