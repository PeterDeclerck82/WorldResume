using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        public string Name { get; set; }
        public string Population { get; set; }
        public string FlagImageUrl { get; set; }
        public string Capital { get; set; }
        public string Languages { get; set; }
        public string Surface { get; set; }
        public string Currency { get; set; }
        public string CountryImageUrl { get; set; }
        public bool IsCountryOfTheWeek { get; set; }

        public int ContinentId { get; set; }
        public string Wallpaper { get; set; }
        public Continent Continent { get; set; }


    }
}
