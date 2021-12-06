using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rcrud.Server.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Osobas",
                columns: new[] { "Id", "Godiste", "Name", "Surname" },
                values: new object[,]
                {
                    { -4, 83, "Asd", "Qwe" },
                    { -3, 345, "Trecko", "Treckovic" },
                    { -2, 35, "Neko", "Nekic" },
                    { -1, 83, "Pera", "Peric" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Osobas",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Osobas",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Osobas",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Osobas",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
