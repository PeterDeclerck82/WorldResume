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
        // GET: /<controller>/

        private readonly ICountryRepository _countryRepository;
        private readonly IContinentRepository _continentRepository;

        public AppController(ICountryRepository countryRepository, IContinentRepository continentRepository)
        {
            _countryRepository      = countryRepository;
            _continentRepository    = continentRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {

            //return View(_pieRepository.AllPies);
            CountriesListViewModel countriesListViewModel = new CountriesListViewModel();
            countriesListViewModel.Countries= _countryRepository.AllCountries;

            countriesListViewModel.CurrentCategory = "Europe";
            return View(countriesListViewModel);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}


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
