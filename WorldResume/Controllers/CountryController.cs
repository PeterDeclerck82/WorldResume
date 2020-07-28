using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldResume.Models;
using WorldResume.ViewModels;

namespace WorldResume.Controllers
{
  
        public class CountryController : Controller
        {
            // GET: /<controller>/

            private readonly ICountryRepository _countryRepository;
            private readonly IContinentRepository _continentRepository;

            public CountryController(ICountryRepository countryRepository, IContinentRepository continentRepository)
            {
                _countryRepository = countryRepository;
                _continentRepository = continentRepository;
            }


            // GET: /<controller>/
            public IActionResult List()
            {

                //return View(_pieRepository.AllPies);
                CountriesListViewModel countriesListViewModel = new CountriesListViewModel();
                countriesListViewModel.Countries = _countryRepository.AllCountries;

                countriesListViewModel.CurrentCategory = "Europe";
                return View(countriesListViewModel);
            }


            public IActionResult Details(int id)
            {
                var country = _countryRepository.GetCountryById(id);
                if (country == null)
                    return NotFound();
                return View(country);
            }
        }
    
}
