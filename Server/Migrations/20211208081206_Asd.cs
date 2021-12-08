using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rcrud.Server.Migrations
{
    public partial class Asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Osobas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Godiste = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobas", x => x.Id);
                });

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
            migrationBuilder.DropTable(
                name: "Osobas");
        }
    }
}
