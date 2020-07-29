using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorldResume.Models;
using WorldResume.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorldResume.Controllers
{
    public class AppController : Controller
    {



        private readonly ICountryRepository _countryRepository;

        public AppController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var appViewModel = new AppViewModel
            {
                CountriesOfTheWeek = _countryRepository.CountriesOfTheWeek
            };

            return View(appViewModel);
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
                //_mailService.SendMail("peter@declerck.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
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
