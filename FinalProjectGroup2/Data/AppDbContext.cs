using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace FinalProjectGroup2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet for TeamMemberEC
        public required DbSet<TeamMemberEC> TeamMembers { get; set; }

        // DbSet for VidGameXM
        public DbSet<VidGameXM> VideoGames { get; set; }

        //DbSet for CollegeTeamMM
        public DbSet<CollegeTeamMM> CollegeTeam { get; set; }

        //DbSet for SpaceShuttleZB
        public DbSet<SpaceShuttleZB> SpaceShuttle { get; set; }


        //DbSet for Products
        public DbSet<ProductKS> Products { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for TeamMemberEC
            modelBuilder.Entity<TeamMemberEC>().HasData(
                new TeamMemberEC
                {
                    Id = 1,
                    FullName = "Xander Marsden",
                    Birthdate = new DateTime(2004, 9, 3),
                    CollegeProgram = "IT",
                    YearInProgram = "Sophomore"
                },
                 new TeamMemberEC
                 {
                     Id = 2,
                     FullName = "Eli Cagle",
                     Birthdate = new DateTime(2000, 06, 02),
                     CollegeProgram = "IT",
                     YearInProgram = "Junior"
                 },
                new TeamMemberEC
                {
                    Id = 3,
                    FullName = "Marian Muntean",
                    Birthdate = new DateTime(1982, 9, 4),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Sophmore"
                },
                new TeamMemberEC
                {
                    Id = 4,
                    FullName = "Zachary Baker",
                    Birthdate = new DateTime(2004, 02, 04),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Freshman"
                },
                new TeamMemberEC
                {
                    Id = 5,
                    FullName = "Kevin Stradman",
                    Birthdate = new DateTime(2024, 11, 27),
                    CollegeProgram = "??",
                    YearInProgram = "??"
                                }
            );

            // Seed data for VidGameXM
            modelBuilder.Entity<VidGameXM>().HasData(
                new VidGameXM
                {
                    Id = 1,
                    FullName = "Xander Marsden",
                    InitialDate = new DateTime(2024, 1, 15),
                    Platform = "PC",
                    GameName = "HellDivers 2"
                },
                new VidGameXM
                {
                    Id = 2,
                    FullName = "Eli Cagle",
                    InitialDate = new DateTime(2023, 12, 15),
                    Platform = "Xbox",
                    GameName = "Call of Duty"
                },
                new VidGameXM
                {
                    Id = 3,
                    FullName = "Marian Muntean",
                    InitialDate = new DateTime(2021, 11, 16),
                    Platform = "PlayStation 4",
                    GameName = "Until Dawn"
                },
                new VidGameXM
                {
                    Id = 4,
                    FullName = "Zachary Baker",
                    InitialDate = new DateTime(2020, 10, 10),
                    Platform = "Xbox",
                    GameName = "Phasmaphobia"
                },
                new VidGameXM
                {
                    Id = 5,
                    FullName = "Kevin Stradman",
                    InitialDate = new DateTime(2022, 10, 11),
                    Platform = "GameCube",
                    GameName = "Sonic Heroes"
                },
                new VidGameXM
                {
                    Id = 6,
                    FullName = "John Doe",
                    InitialDate = new DateTime(2023, 12, 10),
                    Platform = "PlayStation 5",
                    GameName = "Astro Bot"
                }
            );

            // Seed data for CollegeTeam
            modelBuilder.Entity<CollegeTeamMM>().HasData(
                new CollegeTeamMM
                {
                    Id = 1,
                    FullName = "Marian Muntean",
                    City = "Cleveland",
                    FootballTeam = "Ohio State",
                    Mascot = "Brutus Buckeye"
                },
                new CollegeTeamMM
                {
                    Id = 2,
                    FullName = "Xander Marsden",
                    City = "Ann Arbor",
                    FootballTeam = "University of Michigan",
                    Mascot = "Biff, the Michigan Wolverine"
                },
                new CollegeTeamMM
                {
                    Id = 3,
                    FullName = "Eli Cagle",
                    City = "Cincinnati",
                    FootballTeam = "University of Cincinnati",
                    Mascot = "the Bearcat"
                },
                new CollegeTeamMM
                {
                    Id = 4,
                    FullName = "Zachary Baker",
                    City = "Athens",
                    FootballTeam = "Ohio University",
                    Mascot = "Rufus, the Bobcat"
                },
                new CollegeTeamMM
                {
                    Id = 5,
                    FullName = "Kevin Stradman",
                    City = "Lexington",
                    FootballTeam = "University of Kentucky",
                    Mascot = "the Wildcat"
                }
            );

            // Seed data for SpaceShuttleZB
            modelBuilder.Entity<SpaceShuttleZB>().HasData(
                new SpaceShuttleZB 
                { 
                    Id = 1,
                    ShuttleName = "Columbia",
                    FirstLaunch = new DateTime(1981, 04, 12),
                    TotalMissions = 28,
                    LastLaunch = new DateTime(2003, 01, 16)
                },
                new SpaceShuttleZB 
                { 
                    Id = 2,
                    ShuttleName = "Challenger",
                    FirstLaunch = new DateTime(1983, 04, 04),
                    TotalMissions = 10,
                    LastLaunch = new DateTime(1986, 01, 28)
                },
                new SpaceShuttleZB 
                { 
                    Id = 3,
                    ShuttleName = "Discovery",
                    FirstLaunch = new DateTime(1984, 08, 30),
                    TotalMissions = 39,
                    LastLaunch = new DateTime(2011, 02, 24)
                },
                new SpaceShuttleZB 
                { 
                    Id = 4,
                    ShuttleName = "Atlantis",
                    FirstLaunch = new DateTime(1985, 10, 3),
                    TotalMissions = 33,
                    LastLaunch = new DateTime(2011, 07, 08)
                },
                new SpaceShuttleZB 
                { 
                    Id = 5,
                    ShuttleName = "Endeavour",
                    FirstLaunch = new DateTime(1992, 05, 07),
                    TotalMissions = 25,
                    LastLaunch = new DateTime(2011, 05, 16)
                }
            );

            // Seed data for Products
            modelBuilder.Entity<ProductKS>().HasData(
             new ProductKS
             {
                 Id = 1,
                 Name = "Louisville Slugger 2025 Atlas™ (-3) BBCOR Baseball Bat",
                 Description = "EVOKE Alloy Barrel: Designed with the help of artificial intelligence using thousands of computer simulations, resulting in an optimized wall design along the entire length of the barrel.; Updated Premium LS Pro Comfort Grip: For ultimate tack and cushion",
                 Price = 129.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/61GiyaDfNiL.__AC_SX300_SY300_QL70_FMwebp_.jpg"
             },
             new ProductKS
             {
                 Id = 2,
                 Name = "Callaway Golf Strata Men’s Complete Set",
                 Description = "The Strata 12 Piece Set Is Designed For Maximum Performance Right Out Of The Box; The Set Includes: Driver, 3 Wood, 5 Hybrid, 6 - 9 Iron, Pw, Putter, Stand Bag And 2 Head Covers",
                 Price = 319.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/71mCg4W4mRL._AC_SY879_.jpg"
             },
             new ProductKS
             {
                 Id = 3,
                 Name = "Yamato Full Face Golf Wedge Set",
                 Description = "Superior Forgiveness: Our golf wedges are designed with a leading edge that prevents digging into the ground, ensuring forgiveness even on miss-hits. This feature helps eliminate fat shots and allows for more consistent and accurate swings",
                 Price = 92.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/612lRL39zkL._AC_SX679_.jpg"
             },
             new ProductKS
             {
                 Id = 4,
                 Name = "Tangkula 9/10 Pieces Men's Complete Golf Clubs Set Right Hand, Includes 460cc Alloy #1",
                 Description = "EVOKE Alloy Barrel: Designed with the help of artificial intelligence using thousands of computer simulations, resulting in an optimized wall design along the entire length of the barrel.; Updated Premium LS Pro Comfort Grip: For ultimate tack and cushion",
                 Price = 189.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/71wo-1HXVRL.__AC_SX300_SY300_QL70_FMwebp_.jpg"
             },
             new ProductKS
             {
                 Id = 5,
                 Name = "ULTIMATE Men's Complete Golf Club Set - Right Handed, 9/10pcs Golf Clubs Set Includes 460cc #1 Driver, #3 Fairway Wood, #4 Hybrid, #6/#7/#8/#9/#P Irons, ",
                 Description = "【Right Handed Golf Clubs Set for Men】Elevate your golf game with ULTIMATE premium men's golf club set, featuring a complete package of essential clubs to tackle every aspect of your game. The set includes a powerful #1 driver, a #3 fairway wood, a #4 hybrid for long shots, and 6/#7/#8/#9 irons, along with a pitching wedge and a precision putter. This comprehensive set ensures you have the right club for every shot on the course.",
                 Price = 177.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/71Uaeb8o2hL._AC_SX679_.jpg"
             },
             new ProductKS
             {
                 Id = 6,
                 Name = "Stix Golf 9 Club Set - Unisex - Black - 9 Clubs - Graphite Shafts - Premium Materials, Modern Design, Quality",
                 Description = "Stix Golf 9 Club Set - Unisex - Black - 9 Clubs - Graphite Shafts - Premium Materials, Modern Design, Quality",
                 Price = 419.99m,
                 Category = "Sports",
                 ImageUrl = "https://m.media-amazon.com/images/I/611k8ugfwhL.__AC_SX300_SY300_QL70_FMwebp_.jpg"
             }
         );
        }
    }
    

}
