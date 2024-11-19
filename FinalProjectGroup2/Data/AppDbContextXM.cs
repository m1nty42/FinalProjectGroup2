using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;


namespace FinalProjectGroup2.Data
{
    public class AppDbContextXM : DbContext
    {
        public AppDbContextXM(DbContextOptions<AppDbContextXM> options) : base(options) { }


        // DbSet for VidGameXM
        public DbSet<VidGameXM> VideoGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                    FullName = "John Doe",
                    InitialDate = new DateTime(2023, 12, 10),
                    Platform = "PlayStation 5",
                    GameName = "Astro Bot"
                }
            );
        }
    }
    // Add additional DbSet properties for other tables
}
