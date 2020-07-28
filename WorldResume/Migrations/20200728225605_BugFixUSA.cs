using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class BugFixUSA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "CountryImageUrl", "FlagImageUrl" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26371661.859564535!2d-113.72360706725829!3d36.21040627051876!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sVerenigde%20Staten!5e0!3m2!1snl!2sbe!4v1595975530269!5m2!1snl!2sbe", "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "CountryImageUrl", "FlagImageUrl" },
                values: new object[] { "https://www.jetpunk.com/img/user-photo-library/d3/d39bc41c10-235.png", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26371661.859564535!2d-113.72360706725829!3d36.21040627051876!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sVerenigde%20Staten!5e0!3m2!1snl!2sbe!4v1595975530269!5m2!1snl!2sbe" });
        }
    }
}
