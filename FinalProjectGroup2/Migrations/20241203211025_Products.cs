using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup2.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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
                table: "CollegeTeam",
                columns: new[] { "Id", "City", "FootballTeam", "FullName", "Mascot" },
                values: new object[,]
                {
                    { 1, "Cleveland", "Ohio State", "Marian Muntean", "Brutus Buckeye" },
                    { 2, "Ann Arbor", "University of Michigan", "Xander Marsden", "Biff, the Michigan Wolverine" },
                    { 3, "Cincinnati", "University of Cincinnati", "Eli Cagle", "the Bearcat" },
                    { 4, "Athens", "Ohio University", "Zachary Baker", "Rufus, the Bobcat" },
                    { 5, "Lexington", "University of Kentucky", "Kevin Stradman", "the Wildcat" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 215, DateTimeKind.Local).AddTicks(5462), "EVOKE Alloy Barrel: Designed with the help of artificial intelligence using thousands of computer simulations, resulting in an optimized wall design along the entire length of the barrel.; Updated Premium LS Pro Comfort Grip: For ultimate tack and cushion", "https://m.media-amazon.com/images/I/61GiyaDfNiL.__AC_SX300_SY300_QL70_FMwebp_.jpg", "Louisville Slugger 2025 Atlas™ (-3) BBCOR Baseball Bat", 129.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(142) },
                    { 2, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2153), "The Strata 12 Piece Set Is Designed For Maximum Performance Right Out Of The Box; The Set Includes: Driver, 3 Wood, 5 Hybrid, 6 - 9 Iron, Pw, Putter, Stand Bag And 2 Head Covers", "https://m.media-amazon.com/images/I/71mCg4W4mRL._AC_SY879_.jpg", "Callaway Golf Strata Men’s Complete Set", 319.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2160) },
                    { 3, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2165), "Superior Forgiveness: Our golf wedges are designed with a leading edge that prevents digging into the ground, ensuring forgiveness even on miss-hits. This feature helps eliminate fat shots and allows for more consistent and accurate swings", "https://m.media-amazon.com/images/I/612lRL39zkL._AC_SX679_.jpg", "Yamato Full Face Golf Wedge Set", 92.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2166) },
                    { 4, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2169), "EVOKE Alloy Barrel: Designed with the help of artificial intelligence using thousands of computer simulations, resulting in an optimized wall design along the entire length of the barrel.; Updated Premium LS Pro Comfort Grip: For ultimate tack and cushion", "https://m.media-amazon.com/images/I/71wo-1HXVRL.__AC_SX300_SY300_QL70_FMwebp_.jpg", "Tangkula 9/10 Pieces Men's Complete Golf Clubs Set Right Hand, Includes 460cc Alloy #1", 189.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2170) },
                    { 5, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2172), "【Right Handed Golf Clubs Set for Men】Elevate your golf game with ULTIMATE premium men's golf club set, featuring a complete package of essential clubs to tackle every aspect of your game. The set includes a powerful #1 driver, a #3 fairway wood, a #4 hybrid for long shots, and 6/#7/#8/#9 irons, along with a pitching wedge and a precision putter. This comprehensive set ensures you have the right club for every shot on the course.", "https://m.media-amazon.com/images/I/71Uaeb8o2hL._AC_SX679_.jpg", "ULTIMATE Men's Complete Golf Club Set - Right Handed, 9/10pcs Golf Clubs Set Includes 460cc #1 Driver, #3 Fairway Wood, #4 Hybrid, #6/#7/#8/#9/#P Irons, ", 177.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2173) },
                    { 6, "Sports", new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2176), "Stix Golf 9 Club Set - Unisex - Black - 9 Clubs - Graphite Shafts - Premium Materials, Modern Design, Quality", "https://m.media-amazon.com/images/I/611k8ugfwhL.__AC_SX300_SY300_QL70_FMwebp_.jpg", "Stix Golf 9 Club Set - Unisex - Black - 9 Clubs - Graphite Shafts - Premium Materials, Modern Design, Quality", 419.99m, new DateTime(2024, 12, 3, 16, 10, 24, 218, DateTimeKind.Local).AddTicks(2177) }
                });

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

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2004, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Xander Marsden", "Sophomore" },
                    { 2, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "Eli Cagle", "Junior" },
                    { 3, new DateTime(1982, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Marian Muntean", "Sophmore" },
                    { 4, new DateTime(2004, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Zachary Baker", "Freshman" },
                    { 5, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "??", "Kevin Stradman", "??" }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "FullName", "GameName", "InitialDate", "Platform" },
                values: new object[,]
                {
                    { 1, "Xander Marsden", "HellDivers 2", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "PC" },
                    { 2, "Eli Cagle", "Call of Duty", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xbox" },
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
                name: "CollegeTeam");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SpaceShuttle");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "VideoGames");
        }
    }
}
