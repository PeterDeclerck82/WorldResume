using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorldResume.Models
{
    public class WorldResumeContext : DbContext
    {
        public WorldResumeContext (DbContextOptions<WorldResumeContext> options)
            : base(options)
        {
        }

        public DbSet<WorldResume.Models.Country> Country { get; set; }
    }
}
