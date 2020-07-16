﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorldResume.Controllers
{
    public class AppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact us";


            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About us";


            return View();
        }
    }
}
