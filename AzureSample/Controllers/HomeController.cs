﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new NullReferenceException("Sample exception");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page testinnnnnnnn.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}