using Microsoft.EntityFrameworkCore;
namespace VolleyballWebApp.Models
{
    public class VolleyballDbContext : DbContext
    {
        public VolleyballDbContext(DbContextOptions<VolleyballDbContext> options) :base(options)
        {
            
        }
        public DbSet<VolleyballPlayer> VolleyballPlayers { get; set; }


    }
}
