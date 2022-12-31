using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}