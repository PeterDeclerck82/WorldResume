using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Continent> Continents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed continents
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 1, ContinentName = "Africa" });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 2, ContinentName = "Asia" });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 3, ContinentName = "Europe" });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 4, ContinentName = "North-America" });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 5, ContinentName = "South-America" });
            modelBuilder.Entity<Continent>().HasData(new Continent { ContinentId = 6, ContinentName = "Oceania" });


            
                
            //seed countries
            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         1,
                Name =              "China",
                Population =        "1 379 302 771",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/china/flag-3d-250.png",
                Capital =           "Beijing",
                Languages =         "Standard Chinese",
                Surface =           "9 596 961 km2",
                Currency =          "Chinese yuan ¥ (CNY)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/ea/ea7b7f87c2-235.png",
                IsCountryOfTheWeek = false,
                ContinentId =       2
            
            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         2,
                Name =              "Belgium",
                Population =        "11 491 346",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/belgium/flag-3d-250.png",
                Capital =           "Brussels",
                Languages =         "Dutch, French, German",
                Surface =           "30 528 km2",
                Currency =          "Euro € (EUR)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/db/dbecc62d23-235.png",
                IsCountryOfTheWeek = true,
                ContinentId =       3

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         3,
                Name =              "USA",
                Population =        "326 625 791",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png",
                Capital =           "Washington D.C.",
                Languages =         "English",
                Surface =           "9 826 675 km2",
                Currency =          "United States dollar $ (USD)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/d3/d39bc41c10-235.png",
                IsCountryOfTheWeek = false,
                ContinentId =       4

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         4,
                Name =              "Australia",
                Population =        "23 232 413",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png",
                Capital =           "Canberra",
                Languages =         "English",
                Surface =           "7 692 024 km2",
                Currency =          "Australian dollar $ (AUD)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png",
                IsCountryOfTheWeek = true,
                ContinentId =       6

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         5,
                Name =              "Kazakhstan",
                Population =        "18 556 698",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/kazakhstan/flag-3d-250.png",
                Capital =           "Astana",
                Languages =         "Kazakh, Russian",
                Surface =           "2 724 900 km2",
                Currency =          "Kazakhstani tenge (KZT)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/8c/8c905f2cc5-235.png",
                IsCountryOfTheWeek = false,
                ContinentId =       2

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId =         6,
                Name =              "Tanzania",
                Population =        "53 950 935",
                FlagImageUrl =      "https://cdn.countryflags.com/thumbs/tanzania/flag-3d-250.png",
                Capital =           "Dodoma",
                Languages =         "Swahili, English",
                Surface =           "947 303 km2",
                Currency =          "Tanzanian shilling Sh (TZS)",
                CountryImageUrl =   "https://www.jetpunk.com/img/user-photo-library/01/013861b705-235.png",
                IsCountryOfTheWeek = false,
                ContinentId =       1

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId = 7,
                Name = "Ecuador",
                Population = "16 290 913",
                FlagImageUrl = "https://cdn.countryflags.com/thumbs/ecuador/flag-3d-250.png",
                Capital = "Quito",
                Languages = "Spanish",
                Surface = "257 217 km2",
                Currency = "United States dollar $ (USD)",
                CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/2d/2d65bcd234-235.png",
                IsCountryOfTheWeek = true,
                ContinentId = 5

            });

            modelBuilder.Entity<Country>().HasData(new Country
            {
                CountryId = 8,
                Name = "Papua New Guinea",
                Population = "6 909 701",
                FlagImageUrl = "https://cdn.countryflags.com/thumbs/papua-new-guinea/flag-3d-250.png",
                Capital = "Port Moresby",
                Languages = "Hiri Motu, Tok Pisin, Papua New Guinean",
                Surface = "462 840 km2",
                Currency = "Papua New Guinean kina K (PGK)",
                CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/fc/fcdb10ab1f-450.png",
                IsCountryOfTheWeek = true,
                ContinentId = 6

            });


        }
    }
}
