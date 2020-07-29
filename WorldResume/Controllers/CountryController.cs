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
        private readonly ICountryRepository _countryRepository;
        private readonly IContinentRepository _continentRepository;

        public CountryController(ICountryRepository countryRepository, IContinentRepository continentRepository)
        {
            _countryRepository = countryRepository;
            _continentRepository = continentRepository;
        }



        public ViewResult List(string continent)
        {
            IEnumerable<Country> countries;
            string currentContinent;

            if (string.IsNullOrEmpty(continent))
            {
                countries = _countryRepository.AllCountries.OrderBy(p => p.CountryId);
                currentContinent = "All countries";
            }
            else
            {
                countries = _countryRepository.AllCountries.Where(p => p.Continent.ContinentName == continent)
                    .OrderBy(p => p.CountryId);
                currentContinent = _continentRepository.AllContinents.FirstOrDefault(c => c.ContinentName == continent)?.ContinentName;
            }

            return View(new CountriesListViewModel
            {
                Countries = countries,
                CurrentContinent = currentContinent
            });
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
