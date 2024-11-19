using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataXM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "FullName", "GameName", "InitialDate", "Platform" },
                values: new object[,]
                {
                    { 1, "Xander Marsden", "HellDivers 2", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PC" },
                    { 2, "John Doe", "Astro Bot", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PlayStation 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
