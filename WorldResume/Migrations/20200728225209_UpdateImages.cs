using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldResume.Migrations
{
    public partial class UpdateImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Wallpaper",
                table: "Countries",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26963953.548115235!2d86.04746976828892!3d34.414097401049794!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31508e64e5c642c1%3A0x951daa7c349f366f!2sChina!5e0!3m2!1snl!2sbe!4v1595975441411!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d1299490.713551629!2d3.345083548558808!3d50.495695884252356!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47c17d64edf39797%3A0x47ebf2b439e60ff2!2zQmVsZ2nDqw!5e0!3m2!1snl!2sbe!4v1595975338258!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "FlagImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26371661.859564535!2d-113.72360706725829!3d36.21040627051876!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54eab584e432360b%3A0x1c3bb99243deb742!2sVerenigde%20Staten!5e0!3m2!1snl!2sbe!4v1595975530269!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d29616030.892363567!2d115.17403830285546!3d-25.025990989018826!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x2b2bfd076787c5df%3A0x538267a1955b1352!2sAustrali%C3%AB!5e0!3m2!1snl!2sbe!4v1595975578778!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d11008224.282474894!2d57.9311618553116!3d47.65421846398845!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x38a91007ecfca947%3A0x5f7b842fe4b30e1b!2sKazachstan!5e0!3m2!1snl!2sbe!4v1595975626697!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8120963.563762452!2d30.49097463477441!3d-6.353350243585911!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x184b51314869a111%3A0x885a17314bc1c430!2sTanzania!5e0!3m2!1snl!2sbe!4v1595975664940!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8168862.223082799!2d-88.39545770020116!3d-1.3552379218134871!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x902387dda89a4bd5%3A0x9d76af04119c3702!2sEcuador!5e0!3m2!1snl!2sbe!4v1595975706502!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "CountryImageUrl", "Wallpaper" },
                values: new object[] { "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d8120909.665390182!2d145.90250969911793!3d-6.356764602829738!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6859e8afbf0e9eaf%3A0xdaf0e50d8e9c127a!2sPapoea-Nieuw-Guinea!5e0!3m2!1snl!2sbe!4v1595975754546!5m2!1snl!2sbe", "https://cdn.wallpapersafari.com/70/49/Z04RyL.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wallpaper",
                table: "Countries");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/ea/ea7b7f87c2-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/db/dbecc62d23-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                column: "FlagImageUrl",
                value: "https://cdn.countryflags.com/thumbs/united-states-of-america/flag-3d-250.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/ae/ae315bf299-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/8c/8c905f2cc5-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/01/013861b705-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/2d/2d65bcd234-235.png");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                column: "CountryImageUrl",
                value: "https://www.jetpunk.com/img/user-photo-library/fc/fcdb10ab1f-450.png");
        }
    }
}
