using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateVidTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Xander Marsden", "Sophomore" },
                    { 2, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Eli Cagel", "??" },
                    { 3, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Marian Muntean", "??" },
                    { 4, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Zachary Baker", "??" },
                    { 5, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Kevin Stradman", "??" }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "FullName", "GameName", "InitialDate", "Platform" },
                values: new object[,]
                {
                    { 1, "Xander Marsden", "HellDivers 2", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PC" },
                    { 2, "Eli Cagel", "Call of Duty", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox" },
                    { 3, "Marian Muntean", "Until Dawn", new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation 4" },
                    { 4, "Zachary Baker", "Phasmaphobia", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox" },
                    { 5, "Kevin Stradman", "Sonic Heroes", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "GameCube" },
                    { 6, "John Doe", "Astro Bot", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
