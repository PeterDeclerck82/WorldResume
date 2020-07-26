using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class AddPapuaNewGuinea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 6,
                column: "ContinentName",
                value: "Oceania");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "Capital", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { "Port Moresby", "https://www.jetpunk.com/img/user-photo-library/fc/fcdb10ab1f-450.png", "Papua New Guinean kina K (PGK)", "https://cdn.countryflags.com/thumbs/papua-new-guinea/flag-3d-250.png", true, "Hiri Motu, Tok Pisin, Papua New Guinean", "Papua New Guinea", "6 909 701", "462 840 km2" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Capital", "ContinentId", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { 4, "Canberra", 6, "https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png", "Australian dollar $ (AUD)", "https://cdn.countryflags.com/thumbs/australia/flag-3d-250.png", true, "English", "Australia", "23 232 413", "7 692 024 km2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Continents",
                keyColumn: "ContinentId",
                keyValue: 6,
                column: "ContinentName",
                value: "Antarctica");

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "ContinentId", "ContinentName" },
                values: new object[] { 7, "Australia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "Capital", "CountryImageUrl", "Currency", "FlagImageUrl", "IsCountryOfTheWeek", "Languages", "Name", "Population", "Surface" },
                values: new object[] { "Dodoma", "file:///D:/WorldResume/WorldResume/WorldResume/wwwroot/img/AntarticBritShape.PNG", "Pound sterling £ (GBP)", "file:///D:/WorldResume/WorldResume/WorldResume/wwwroot/img/AntarticBrit.png", false, "English", "British Antarctic Territory", "estimate 250", "1,709,400 km2" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "ContinentId",
                value: 7);
        }
    }
}
