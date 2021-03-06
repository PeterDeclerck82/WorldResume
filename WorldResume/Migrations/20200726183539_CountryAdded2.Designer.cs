﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldResume.Models;

namespace WorldResume.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200726183539_CountryAdded2")]
    partial class CountryAdded2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldResume.Models.Continent", b =>
                {
                    b.Property<int>("ContinentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContinentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContinentId");

                    b.ToTable("Continents");

                    b.HasData(
                        new
                        {
                            ContinentId = 1,
                            ContinentName = "Africa"
                        },
                        new
                        {
                            ContinentId = 2,
                            ContinentName = "Asia"
                        },
                        new
                        {
                            ContinentId = 3,
                            ContinentName = "Europe"
                        },
                        new
                        {
                            ContinentId = 4,
                            ContinentName = "North-America"
                        },
                        new
                        {
                            ContinentId = 5,
                            ContinentName = "South-America"
                        },
                        new
                        {
                            ContinentId = 6,
                            ContinentName = "Antarctica"
                        },
                        new
                        {
                            ContinentId = 7,
                            ContinentName = "Australia"
                        });
                });

            modelBuilder.Entity("WorldResume.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capital")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("CountryImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCountryOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Population")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surface")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.HasIndex("ContinentId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Capital = "Beijing",
                            ContinentId = 2,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/ea/ea7b7f87c2-235.png",
                            Currency = "Chinese yuan ¥ (CNY)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/china/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Standard Chinese",
                            Name = "China",
                            Population = "1 379 302 771",
                            Surface = "9 596 961 km2"
                        },
                        new
                        {
                            CountryId = 2,
                            Capital = "Brussels",
                            ContinentId = 3,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/db/dbecc62d23-235.png",
                            Currency = "Euro € (EUR)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/belgium/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "Dutch, French, German",
                            Name = "Belgium",
                            Population = "11 491 346",
                            Surface = "30 528 km2"
                        },
                        new
                        {
                            CountryId = 3,
                            Capital = "Washington D.C.",
                            ContinentId = 4,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/d3/d39bc41c10-235.png",
                            Currency = "United States dollar $ (USD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "English",
                            Name = "USA",
                            Population = "326 625 791",
                            Surface = "9 826 675 km2"
                        },
                        new
                        {
                            CountryId = 4,
                            Capital = "Canberra",
                            ContinentId = 7,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png",
                            Currency = "Australian dollar $ (AUD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "English",
                            Name = "Australia",
                            Population = "23 232 413",
                            Surface = "7 692 024 km2"
                        },
                        new
                        {
                            CountryId = 5,
                            Capital = "Astana",
                            ContinentId = 2,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/8c/8c905f2cc5-235.png",
                            Currency = "Kazakhstani tenge (KZT)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/kazakhstan/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Kazakh, Russian",
                            Name = "Kazakhstan",
                            Population = "18 556 698",
                            Surface = "2 724 900 km2"
                        },
                        new
                        {
                            CountryId = 6,
                            Capital = "Dodoma",
                            ContinentId = 1,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/01/013861b705-235.png",
                            Currency = "Tanzanian shilling Sh (TZS)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/tanzania/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Swahili, English",
                            Name = "Tanzania",
                            Population = "53 950 935",
                            Surface = "947 303 km2"
                        },
                        new
                        {
                            CountryId = 7,
                            Capital = "Quito",
                            ContinentId = 5,
                            CountryImageUrl = "https://www.jetpunk.com/img/user-photo-library/2d/2d65bcd234-235.png",
                            Currency = "United States dollar $ (USD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/ecuador/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "Spanish",
                            Name = "Ecuador",
                            Population = "16 290 913",
                            Surface = "257 217 km2"
                        },
                        new
                        {
                            CountryId = 8,
                            Capital = "London",
                            ContinentId = 6,
                            CountryImageUrl = "~/WorldResume/wwwroot/img/AntarticBritShape.PNG",
                            Currency = "Pound sterling £ (GBP)",
                            FlagImageUrl = "~/WorldResume/wwwroot/img/AntarticBrit.png",
                            IsCountryOfTheWeek = false,
                            Languages = "English",
                            Name = "British Antarctic Territory",
                            Population = "estimate 250",
                            Surface = "1,709,400 km2"
                        });
                });

            modelBuilder.Entity("WorldResume.Models.Country", b =>
                {
                    b.HasOne("WorldResume.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
