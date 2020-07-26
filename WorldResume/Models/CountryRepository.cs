using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class CountryRepository: ICountryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public IEnumerable<Country> AllCountries 
        {
            get
            {
                return _appDbContext.Countries.Include(c => c.Continent);
            }
        }

        public IEnumerable<Country> CountriesOfTheWeek
        {
            get
            {
                return _appDbContext.Countries.Include(c => c.Continent).Where(p => p.IsCountryOfTheWeek);
            }
        }

        public Country GetCountryById(int countryId)
        {
            return _appDbContext.Countries.FirstOrDefault(p => p.CountryId == countryId);
        }
    }
}
