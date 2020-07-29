﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldResume.Models;

namespace WorldResume.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ContinentName = "Oceania"
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

                    b.Property<string>("Wallpaper")
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
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26963953.548115235!2d86.04746976828892!3d34.414097401049794!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31508e64e5c642c1%3A0x951daa7c349f366f!2sChina!5e0!3m2!1snl!2sbe!4v1595975441411!5m2!1snl!2sbe",
                            Currency = "Chinese yuan ¥ (CNY)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/china/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Standard Chinese",
                            Name = "China",
                            Population = "1 379 302 771",
                            Surface = "9 596 961 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 2,
                            Capital = "Brussels",
                            ContinentId = 3,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1299490.713551629!2d3.345083548558808!3d50.495695884252356!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c17d64edf39797%3A0x47ebf2b439e60ff2!2zQmVsZ2nDqw!5e0!3m2!1snl!2sbe!4v1595975338258!5m2!1snl!2sbe",
                            Currency = "Euro € (EUR)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/belgium/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "Dutch, French, German",
                            Name = "Belgium",
                            Population = "11 491 346",
                            Surface = "30 528 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 3,
                            Capital = "Washington D.C.",
                            ContinentId = 4,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26371661.859564535!2d-113.72360706725829!3d36.21040627051876!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sVerenigde%20Staten!5e0!3m2!1snl!2sbe!4v1595975530269!5m2!1snl!2sbe",
                            Currency = "United States dollar $ (USD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "English",
                            Name = "USA",
                            Population = "326 625 791",
                            Surface = "9 826 675 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 4,
                            Capital = "Canberra",
                            ContinentId = 6,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d29616030.892363567!2d115.17403830285546!3d-25.025990989018826!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x2b2bfd076787c5df%3A0x538267a1955b1352!2sAustrali%C3%AB!5e0!3m2!1snl!2sbe!4v1595975578778!5m2!1snl!2sbe",
                            Currency = "Australian dollar $ (AUD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "English",
                            Name = "Australia",
                            Population = "23 232 413",
                            Surface = "7 692 024 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 5,
                            Capital = "Astana",
                            ContinentId = 2,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11008224.282474894!2d57.9311618553116!3d47.65421846398845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x38a91007ecfca947%3A0x5f7b842fe4b30e1b!2sKazachstan!5e0!3m2!1snl!2sbe!4v1595975626697!5m2!1snl!2sbe",
                            Currency = "Kazakhstani tenge (KZT)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/kazakhstan/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Kazakh, Russian",
                            Name = "Kazakhstan",
                            Population = "18 556 698",
                            Surface = "2 724 900 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 6,
                            Capital = "Dodoma",
                            ContinentId = 1,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8120963.563762452!2d30.49097463477441!3d-6.353350243585911!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x184b51314869a111%3A0x885a17314bc1c430!2sTanzania!5e0!3m2!1snl!2sbe!4v1595975664940!5m2!1snl!2sbe",
                            Currency = "Tanzanian shilling Sh (TZS)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/tanzania/flag-3d-250.png",
                            IsCountryOfTheWeek = false,
                            Languages = "Swahili, English",
                            Name = "Tanzania",
                            Population = "53 950 935",
                            Surface = "947 303 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 7,
                            Capital = "Quito",
                            ContinentId = 5,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8168862.223082799!2d-88.39545770020116!3d-1.3552379218134871!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x902387dda89a4bd5%3A0x9d76af04119c3702!2sEcuador!5e0!3m2!1snl!2sbe!4v1595975706502!5m2!1snl!2sbe",
                            Currency = "United States dollar $ (USD)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/ecuador/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "Spanish",
                            Name = "Ecuador",
                            Population = "16 290 913",
                            Surface = "257 217 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
                        },
                        new
                        {
                            CountryId = 8,
                            Capital = "Port Moresby",
                            ContinentId = 6,
                            CountryImageUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8120909.665390182!2d145.90250969911793!3d-6.356764602829738!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6859e8afbf0e9eaf%3A0xdaf0e50d8e9c127a!2sPapoea-Nieuw-Guinea!5e0!3m2!1snl!2sbe!4v1595975754546!5m2!1snl!2sbe",
                            Currency = "Papua New Guinean kina K (PGK)",
                            FlagImageUrl = "https://cdn.countryflags.com/thumbs/papua-new-guinea/flag-3d-250.png",
                            IsCountryOfTheWeek = true,
                            Languages = "Hiri Motu, Tok Pisin, Papua New Guinean",
                            Name = "Papua New Guinea",
                            Population = "6 909 701",
                            Surface = "462 840 km2",
                            Wallpaper = "https://images.squarespace-cdn.com/content/v1/598dd18f49fc2b04c6d398cd/1524600056681-35VGO0VJ1FCDBAP9309N/ke17ZwdGBToddI8pDm48kG4Lt-JYfhsgzER8wYsMOK4UqsxRUqqbr1mOJYKfIPR7LoDQ9mXPOjoJoqy81S2I8N_N4V1vUb5AoIIIbLZhVYy7Mythp_T-mtop-vrsUOmeInPi9iDjx9w8K4ZfjXt2djx7qs_dQInDleYV8prELvY9ei-gS7um8677v-vr5NXEZtJ3qR9G2BYeA0wOAaeYNg/44274_KiawahRiver_preview.jpeg"
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
