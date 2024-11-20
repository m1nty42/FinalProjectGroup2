﻿using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;
using System.Xml;


namespace FinalProjectGroup2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


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
        }
    }
    // Add additional DbSet properties for other tables
}