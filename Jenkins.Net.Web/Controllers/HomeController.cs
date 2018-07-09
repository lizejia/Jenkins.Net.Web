using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jenkins.Net.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly string PublishVersion = ConfigurationManager.AppSettings["PublishVersion"];
        public ActionResult Index()
        {
            ViewBag.PublishVersion = PublishVersion;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}