using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldResume.Models;

namespace WorldResume.ViewModels
{
    public class AppViewModel
    {
        public IEnumerable<Country> CountriesOfTheWeek { get; set; }
    }
}
