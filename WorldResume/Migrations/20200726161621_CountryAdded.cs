using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class CountryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Capital", "ContinentId", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { 6, "Dodoma", 1, "https://www.jetpunk.com/img/user-photo-library/01/013861b705-235.png", "Tanzanian shilling Sh (TZS)", "https://cdn.countryflags.com/thumbs/tanzania/flag-3d-250.png", false, "Swahili, English", "Tanzania", "53 950 935", "947 303 km2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);
        }
    }
}
