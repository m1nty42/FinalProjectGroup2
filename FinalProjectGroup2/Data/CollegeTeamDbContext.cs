using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;

namespace FinalProjectGroup2.Data

     //Marian Muntean
{
    public class CollegeTeamDbContext : DbContext
    {
        public CollegeTeamDbContext(DbContextOptions<CollegeTeamDbContext> options) : base(options) { }


        // DbSet for CollegeTeamMM
        public DbSet<CollegeTeamMM> CollegeTeam { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for CollegeTeamMM
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
                    FullName = "Eli Cagel",
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
                    FootballTeam = "University of Kentuky",
                    Mascot = "the Wildcat"
                }
            );
        }
    }
  
}

