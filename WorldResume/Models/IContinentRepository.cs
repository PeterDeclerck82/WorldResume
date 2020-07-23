using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public interface IContinentRepository
    {
        IEnumerable<Continent> AllContinents { get; }
    }
}
