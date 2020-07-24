using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class MockCountryRepository: ICountryRepository
    {

        private readonly IContinentRepository _continentRepository = new MockContinentRepository();
        public IEnumerable<Country> AllCountries =>
            new List<Country>
            {
                new Country{CountryId= 1, Name= "China"      ,Population= "1 379 302 771"  ,FlagImageUrl="https://cdn.countryflags.com/thumbs/china/flag-3d-250.png"                    ,Capital= "Beijing"        ,Languages= "Standard Chinese"     ,Surface= "9 596 961 km2"      ,Currency= "Chinese yuan ¥ (CNY)"         ,CountryImageUrl="https://www.jetpunk.com/img/user-photo-library/ea/ea7b7f87c2-235.png" ,IsCountryOfTheWeek= false    ,Continent = _continentRepository.AllContinents.ToList()[1]}, // Asia
                new Country{CountryId= 2, Name= "Belgium"    ,Population= "11 491 346"     ,FlagImageUrl="https://cdn.countryflags.com/thumbs/belgium/flag-3d-250.png"                  ,Capital= "Brussels"       ,Languages= "Dutch, French, German",Surface= "30 528 km2"         ,Currency= "Euro € (EUR)"                 ,CountryImageUrl="https://www.jetpunk.com/img/user-photo-library/db/dbecc62d23-235.png" ,IsCountryOfTheWeek= true     ,Continent = _continentRepository.AllContinents.ToList()[2]}, // Europe
                new Country{CountryId= 3, Name= "USA"        ,Population= "326 625 791"    ,FlagImageUrl="https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png" ,Capital= "Washington D.C.",Languages= "English"              ,Surface= "9 826 675 km2"      ,Currency= "United States dollar $ (USD)" ,CountryImageUrl="https://www.jetpunk.com/img/user-photo-library/d3/d39bc41c10-235.png" ,IsCountryOfTheWeek= false    ,Continent = _continentRepository.AllContinents.ToList()[3]}, // North America
                new Country{CountryId= 4, Name= "Australia"  ,Population= "23 232 413"     ,FlagImageUrl="https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png"                ,Capital= "Canberra"       ,Languages= "English"              ,Surface= "7 692 024 km2"      ,Currency= "Australian dollar $ (AUD)"    ,CountryImageUrl="https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png" ,IsCountryOfTheWeek= true     ,Continent = _continentRepository.AllContinents.ToList()[6]}, // Australia
                new Country{CountryId= 5, Name= "Kazakhstan" ,Population= "18 556 698"     ,FlagImageUrl="https://cdn.countryflags.com/thumbs/kazakhstan/flag-3d-250.png"               ,Capital= "Astana"         ,Languages= "Kazakh, Russian"      ,Surface= "2 724 900 km2"      ,Currency= "Kazakhstani tenge (KZT)"      ,CountryImageUrl="https://www.jetpunk.com/img/user-photo-library/8c/8c905f2cc5-235.png" ,IsCountryOfTheWeek= false    ,Continent = _continentRepository.AllContinents.ToList()[1]}  // Asia

            };

        public IEnumerable<Country> CountriesOfTheWeek { get; }


        public Country GetCountryById(int countryId)
        {
            return AllCountries.FirstOrDefault(p => p.CountryId == countryId);
        }
    }
}
