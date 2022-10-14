using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Caso1_20101061_Vilcatoma.Migrations
{
    public partial class CreandoBDPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Dorsal = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ACountry = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
