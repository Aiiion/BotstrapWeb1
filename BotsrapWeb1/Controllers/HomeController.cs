using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BotsrapWeb1.Controllers
{
    public class HomeController : Controller
    {
        // GET: first
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
    public class jobs
    {
        public string employer;
        public string position;
        public string duration;
    }
}