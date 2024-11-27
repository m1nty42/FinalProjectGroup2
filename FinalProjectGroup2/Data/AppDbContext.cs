using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;


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


        //DbSet for Food


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
                     FullName = "Eli Cagel",
                     Birthdate = new DateTime(2024, 11, 27),
                     CollegeProgram = "??",
                     YearInProgram = "??"
                 },
                new TeamMemberEC
                {
                    Id = 3,
                    FullName = "Marian Muntean",
                    Birthdate = new DateTime(2024, 11, 27),
                    CollegeProgram = "??",
                    YearInProgram = "??"
                },
                new TeamMemberEC
                {
                    Id = 4,
                    FullName = "Zachary Baker",
                    Birthdate = new DateTime(2024, 11, 27),
                    CollegeProgram = "??",
                    YearInProgram = "??"
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
                    FullName = "Eli Cagel",
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


            // Seed data for Food


            // Seed data for Animal
        }
    }
    

}
