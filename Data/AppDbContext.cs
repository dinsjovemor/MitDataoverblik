using Microsoft.EntityFrameworkCore;
using MitDataoverblik.Models;

namespace MitDataoverblik.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Borger> Borgere { get; set; }
    }
}
