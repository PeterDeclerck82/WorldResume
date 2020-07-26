using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class CountryAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Capital", "ContinentId", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { 7, "Quito", 5, "https://www.jetpunk.com/img/user-photo-library/2d/2d65bcd234-235.png", "United States dollar $ (USD)", "https://cdn.countryflags.com/thumbs/ecuador/flag-3d-250.png", true, "Spanish", "Ecuador", "16 290 913", "257 217 km2" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Capital", "ContinentId", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { 8, "London", 6, "~/WorldResume/wwwroot/img/AntarticBritShape.PNG", "Pound sterling £ (GBP)", "~/WorldResume/wwwroot/img/AntarticBrit.png", false, "English", "British Antarctic Territory", "estimate 250", "1,709,400 km2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8);
        }
    }
}
