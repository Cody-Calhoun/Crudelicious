using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Dishes> Dishes { get; set; }
        // public DbSet<Chef> Chefs { get; set; }

    }
}

