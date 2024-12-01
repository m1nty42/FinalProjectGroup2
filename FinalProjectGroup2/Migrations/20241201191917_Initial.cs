using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollegeTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FootballTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mascot = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeTeam", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CollegeTeam",
                columns: new[] { "Id", "City", "FootballTeam", "FullName", "Mascot" },
                values: new object[,]
                {
                    { 1, "Cleveland", "Ohio State", "Marian Muntean", "Brutus Buckeye" },
                    { 2, "Ann Arbor", "University of Michigan", "Xander Marsden", "Biff, the Michigan Wolverine" },
                    { 3, "Cincinnati", "University of Cincinnati", "Eli Cagel", "the Bearcat" },
                    { 4, "Athens", "Ohio University", "Zachary Baker", "Rufus, the Bobcat" },
                    { 5, "Lexington", "University of Kentuky", "Kevin Stradman", "the Wildcat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeTeam");
        }
    }
}
