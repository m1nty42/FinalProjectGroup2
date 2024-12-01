using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup2.Migrations
{
    /// <inheritdoc />
    public partial class ZBInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpaceShuttle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShuttleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstLaunch = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMissions = table.Column<int>(type: "int", nullable: false),
                    LastLaunch = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaceShuttle", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CollegeTeam",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullName",
                value: "Eli Cagle");

            migrationBuilder.UpdateData(
                table: "CollegeTeam",
                keyColumn: "Id",
                keyValue: 5,
                column: "FootballTeam",
                value: "University of Kentucky");

            migrationBuilder.InsertData(
                table: "SpaceShuttle",
                columns: new[] { "Id", "FirstLaunch", "LastLaunch", "ShuttleName", "TotalMissions" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbia", 28 },
                    { 2, new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Challenger", 10 },
                    { 3, new DateTime(1984, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discovery", 39 },
                    { 4, new DateTime(1985, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atlantis", 33 },
                    { 5, new DateTime(1992, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2011, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Endeavour", 25 }
                });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Eli Cagle", "Junior" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CollegeProgram", "YearInProgram" },
                values: new object[] { new DateTime(1982, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Sophmore" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "CollegeProgram", "YearInProgram" },
                values: new object[] { new DateTime(2004, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Freshman" });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Eli Cagle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpaceShuttle");

            migrationBuilder.UpdateData(
                table: "CollegeTeam",
                keyColumn: "Id",
                keyValue: 3,
                column: "FullName",
                value: "Eli Cagel");

            migrationBuilder.UpdateData(
                table: "CollegeTeam",
                keyColumn: "Id",
                keyValue: 5,
                column: "FootballTeam",
                value: "University of Kentuky");

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Eli Cagel", "??" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Birthdate", "CollegeProgram", "YearInProgram" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "??" });

            migrationBuilder.UpdateData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Birthdate", "CollegeProgram", "YearInProgram" },
                values: new object[] { new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "??" });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "FullName",
                value: "Eli Cagel");
        }
    }
}
