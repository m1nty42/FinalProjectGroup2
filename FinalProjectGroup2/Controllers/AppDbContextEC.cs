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
    }
}
