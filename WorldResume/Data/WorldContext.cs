using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldResume.Data.Entities;

namespace WorldResume.Data
{
    public class WorldContext : DbContext
    {
        public WorldContext(DbContextOptions<WorldContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
