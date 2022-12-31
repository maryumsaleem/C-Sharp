using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class GameController : Controller
    {
        public string Name(string name)
            {
            return "Welcome to " + name;
            }

        public string FullName(string FirstName, string LastName)
        {
          if (!string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName))
            {
                return "Your first Name is= " + FirstName;
            }
            else if (string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            {
                return "your Last Name is= " + LastName;
            }

           else
            {
                return "Your first Name is= " + FirstName + " and Last Name is= " + LastName;
            }
        }
    }
    
}