using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //Getemployee func of Employee model class
        private Employee GetEmployee()
            
        {
            return new Employee()
            {
                Id = 1,
                Name = "Webgentel",
                Address = "Pakistan"
            };
        }
    }
}