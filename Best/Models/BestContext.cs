using Microsoft.EntityFrameworkCore;

namespace Best.Models
{
    public class BestContext : DbContext
    {

        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }

        public BestContext(DbContextOptions options) : base(options) { }

    }
}