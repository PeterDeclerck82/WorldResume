using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class MockContinentRepository: IContinentRepository
    {
        public IEnumerable<Continent> AllContinents =>
            new List<Continent>
            {
                new Continent{ContinentId=1, ContinentName="Africa"},
                new Continent{ContinentId=2, ContinentName="Asia"},
                new Continent{ContinentId=3, ContinentName="Europe"},
                new Continent{ContinentId=4, ContinentName="North-America"},
                new Continent{ContinentId=5, ContinentName="South-America"},
                new Continent{ContinentId=6, ContinentName="Oceania"},

                                          
            };
    }

}
