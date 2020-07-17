using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldResume.ViewModels;

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


        [HttpGet("contact")]
        public IActionResult Contact()
        {


            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Send the email
            }
            else
            {
                // Show the errors
            }

            return View();

        }


        [HttpGet("about")]
        public IActionResult About()
        {

            return View();
        }
    }
}
