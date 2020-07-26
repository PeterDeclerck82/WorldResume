using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class UpdateAntartic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "Capital", "CountryImageUrl", "FlagImageUrl" },
                values: new object[] { "Dodoma", "file:///D:/WorldResume/WorldResume/WorldResume/wwwroot/img/AntarticBritShape.PNG", "file:///D:/WorldResume/WorldResume/WorldResume/wwwroot/img/AntarticBrit.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "Capital", "CountryImageUrl", "FlagImageUrl" },
                values: new object[] { "London", "~/WorldResume/wwwroot/img/AntarticBritShape.PNG", "~/WorldResume/wwwroot/img/AntarticBrit.png" });
        }
    }
}
