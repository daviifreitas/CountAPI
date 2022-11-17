using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Register> Registers { get; set; }
    }
}
