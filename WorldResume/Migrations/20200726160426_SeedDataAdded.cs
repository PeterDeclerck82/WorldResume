using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "ContinentName" },
                values: new object[,]
                {
                    { 1, "Africa" },
                    { 2, "Asia" },
                    { 3, "Europe" },
                    { 4, "North-America" },
                    { 5, "South-America" },
                    { 6, "Antarctica" },
                    { 7, "Australia" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Capital", "ContinentId", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[,]
                {
                    { 1, "Beijing", 2, "https://www.jetpunk.com/img/user-photo-library/ea/ea7b7f87c2-235.png", "Chinese yuan ¥ (CNY)", "https://cdn.countryflags.com/thumbs/china/flag-3d-250.png", false, "Standard Chinese", "China", "1 379 302 771", "9 596 961 km2" },
                    { 5, "Astana", 2, "https://www.jetpunk.com/img/user-photo-library/8c/8c905f2cc5-235.png", "Kazakhstani tenge (KZT)", "https://cdn.countryflags.com/thumbs/kazakhstan/flag-3d-250.png", false, "Kazakh, Russian", "Kazakhstan", "18 556 698", "2 724 900 km2" },
                    { 2, "Brussels", 3, "https://www.jetpunk.com/img/user-photo-library/db/dbecc62d23-235.png", "Euro € (EUR)", "https://cdn.countryflags.com/thumbs/belgium/flag-3d-250.png", true, "Dutch, French, German", "Belgium", "11 491 346", "30 528 km2" },
                    { 3, "Washington D.C.", 4, "https://www.jetpunk.com/img/user-photo-library/d3/d39bc41c10-235.png", "United States dollar $ (USD)", "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png", false, "English", "USA", "326 625 791", "9 826 675 km2" },
                    { 4, "Canberra", 7, "https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png", "Australian dollar $ (AUD)", "https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png", true, "English", "Australia", "23 232 413", "7 692 024 km2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 7);
        }
    }
}
