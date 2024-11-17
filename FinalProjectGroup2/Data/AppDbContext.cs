using Microsoft.EntityFrameworkCore;
using FinalProjectGroup2.Models;


namespace FinalProjectGroup2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<VidGameXM> VideoGames { get; set; }
        // Add additional DbSet properties for other tables
    }
}
