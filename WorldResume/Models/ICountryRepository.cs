using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> AllCountries { get; }
        IEnumerable<Country> CountriesOfTheWeek { get; }
        Country GetCountryById(int countryId);
    }
}
