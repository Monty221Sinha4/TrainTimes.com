using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Traintime.com.Controllers.Home
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //GET: About US 
        public ActionResult AboutUS()
        {
            return View();
        }
        //GET :Contact
      public ActionResult Contact()
        {
            return View();
        }
        //GET : Departure table 
        public ActionResult Departure()
        {
            return View();
        }
        // GET :Arrivals table
        public ActionResult Arrival()
        {
            return View();
        }
    }
}