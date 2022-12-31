using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        //action method below
        public string EmployeeProfile(int id)//parameters in action method
        {
            string profile = string.Empty;
            if (id == 1)
            {
                profile = "Employee 1 profile";
            }
            else if (id == 2)
            {
                profile = "Employye 2 profile";
            }
            else
            {
                profile = "No record found";
            }
            return profile;
        }
        public string Address(int id,string department)
        {
            return "id=" + id + "departmet=" + department;
        }

        public string Address1(int id, int? code=null)//code is nullable parameter you can leave it null in url of browser
        {
            return "id=" + id + "code=" + code;
        }
    }
}