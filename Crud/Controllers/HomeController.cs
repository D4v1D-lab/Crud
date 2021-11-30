using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the information of our page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "These are our contacts";

            return View();
        }
    }
}