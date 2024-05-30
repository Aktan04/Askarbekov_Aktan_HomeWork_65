using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeWork65.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OfficialName = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    SubRegion = table.Column<string>(type: "text", nullable: false),
                    Population = table.Column<int>(type: "integer", nullable: false),
                    Capital = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Name", "OfficialName", "Population", "Region", "SubRegion" },
                values: new object[,]
                {
                    { 1, "Tokyo", "Japan", "State of Japan", 126300000, "Asia", "Eastern Asia" },
                    { 2, "Brasília", "Brazil", "Federative Republic of Brazil", 213000000, "South America", "South America" },
                    { 3, "Canberra", "Australia", "Commonwealth of Australia", 25690000, "Oceania", "Australia and New Zealand" },
                    { 4, "New Delhi", "India", "Republic of India", 1380000000, "Asia", "Southern Asia" },
                    { 5, "Mexico City", "Mexico", "United Mexican States", 128900000, "North America", "Central America" },
                    { 6, "Rome", "Italy", "Italian Republic", 60000000, "Europe", "Southern Europe" },
                    { 7, "Cairo", "Egypt", "Arab Republic of Egypt", 104000000, "Africa", "Northern Africa" },
                    { 8, "Seoul", "South Korea", "Republic of Korea", 51700000, "Asia", "Eastern Asia" },
                    { 9, "Buenos Aires", "Argentina", "Argentine Republic", 45380000, "South America", "South America" },
                    { 10, "Pretoria (administrative), Bloemfontein (judicial), Cape Town (legislative)", "South Africa", "Republic of South Africa", 59300000, "Africa", "Southern Africa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
