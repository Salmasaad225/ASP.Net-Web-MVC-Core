using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class kjkjk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "continent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_continent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    continant_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.ID);
                    table.ForeignKey(
                        name: "FK_country_continent_continant_ID",
                        column: x => x.continant_ID,
                        principalTable: "continent",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.ID);
                    table.ForeignKey(
                        name: "FK_city_country_country_ID",
                        column: x => x.country_ID,
                        principalTable: "country",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_city_country_ID",
                table: "city",
                column: "country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_country_continant_ID",
                table: "country",
                column: "continant_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "country");

            migrationBuilder.DropTable(
                name: "continent");
        }
    }
}
