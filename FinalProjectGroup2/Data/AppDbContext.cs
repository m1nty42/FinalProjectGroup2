using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;
using System.Collections.Generic;


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


        //DbSet for Animal



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



            // Seed data for Animal
        }
    }
    

}
