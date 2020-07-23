using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class Continent
    {
        public int ContinentId { get; set; }
        public string ContinentName { get; set; }
        public List<Country> Countries { get; set; }
    }
}
