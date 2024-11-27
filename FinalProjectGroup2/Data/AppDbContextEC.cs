using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;

namespace FinalProjectGroup2.Data
{
    public class AppDbContextEC : DbContext
    {
        public AppDbContextEC(DbContextOptions<AppDbContextEC> options)
            : base(options)
        {
        }

        public DbSet<TeamMemberEC> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for TeamMembersEC
            modelBuilder.Entity<VidGameXM>().HasData(
                new TeamMemberEC
                {
                    Id = 1,
                    FullName = "Xander Marsden",
                    Birthdate = new DateTime(2024, 1, 15),
                    CollegeProgram = "Insert Program Here",
                    YearInProgram = "Insert Year Here"
                },
                new TeamMemberEC
                {
                    Id = 2,
                    FullName = "Eli Cagle",
                    Birthdate = new DateTime(2003, 06, 02),
                    CollegeProgram = "Information Techhnology",
                    YearInProgram = "3"
                },
                new TeamMemberEC
                {
                    Id = 3,
                    FullName = "Marian Muntean",
                    Birthdate = new DateTime(2021, 11, 16),
                    CollegeProgram  = "Insert Program Here",
                    YearInProgram = "Insert Year Here"
                },
                new TeamMemberEC
                {
                    Id = 4,
                    FullName = "Zachary Baker",
                    Birthdate = new DateTime(2020, 10, 10),
                    CollegeProgram = "Insert Program Here",
                    YearInProgram = "Insert Year Here"
                },
                new TeamMemberEC
                {
                    Id = 5,
                    FullName = "Kevin Stradman",
                    Birthdate = new DateTime(2022, 10, 11),
                    CollegeProgram = "Insert Program Here",
                    YearInProgram = "Insert Year Here"
                },
                new TeamMemberEC
                {
                    Id = 6,
                    FullName = "John Doe",
                    Birthdate = new DateTime(2023, 12, 10),
                    CollegeProgram = "Insert Program Here",
                    YearInProgram = "Insert Year Here"
                }
            );
        }
    }
  
}

    

