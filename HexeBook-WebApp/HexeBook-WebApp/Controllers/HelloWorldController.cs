using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HexeBook_WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public string Index()
        {
            return "Thi is my <b>default</b> action 2";
            //return View();
        }

        public string Welcome()
        {
            return "This is my welcome method";
        }
    }
}