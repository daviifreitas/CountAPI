using Microsoft.EntityFrameworkCore;

namespace Count01.API.Model
{
    public class CountAPIDbContext : DbContext
    {
        public CountAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CountModel> CountModels { get; set; }
    }
}
