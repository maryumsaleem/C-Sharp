﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//main reference of HomeController class

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
           return "Hello from webGenttel";
        }
        public string Name()
        {
            return "My name is maryum";
        }
    }
}