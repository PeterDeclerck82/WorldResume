using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldResume.Models;

namespace WorldResume.ViewModels
{
    public class CountriesListViewModel
    {
        public IEnumerable<Country> Countries { get; set; }
        public string CurrentContinent { get; set; }
    }
}
