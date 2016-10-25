using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //GET: Welcome
        //public string Welcome()
        //{
        //    return "Welcome action method called";
        //}

        public ActionResult Welcome(string name, int count = 1)
        {
            ViewBag.name = name;
            ViewBag.count = count;

            return View();
        }

    }
}