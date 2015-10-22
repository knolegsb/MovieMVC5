using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieMVC5.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWord
        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        // GET: /HelloWorld/Welcome/
        //public string Welcome(string name, int numTimes = 1) 
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        ////public string Welcome(string name, int ID = 1)
        ////{
        ////    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        ////}
    }
}