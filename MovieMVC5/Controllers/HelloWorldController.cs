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
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}