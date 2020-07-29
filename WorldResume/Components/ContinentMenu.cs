using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldResume.Models;

namespace WorldResume.Components
{
    
        public class ContinentMenu : ViewComponent
        {
            private readonly IContinentRepository _continentRepository;
            public ContinentMenu(IContinentRepository continentRepository)
            {
                _continentRepository = continentRepository;
            }

            public IViewComponentResult Invoke()
            {
                var continents = _continentRepository.AllContinents.OrderBy(c => c.ContinentName);
                return View(continents);
            }
        }
    
}
