using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class ContinentRepository : IContinentRepository
    {
        private readonly AppDbContext _appDbContext;
        public ContinentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Continent> AllContinents => _appDbContext.Continents;
    }
}
