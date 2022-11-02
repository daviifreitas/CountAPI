using Count.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Count.API.Context
{
    public class CountAPIDbContext : DbContext
    {
        public CountAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CountModel> CountModels { get; set; }
    }
}
