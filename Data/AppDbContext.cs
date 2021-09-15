using Microsoft.EntityFrameworkCore;
using CommanderGraphQL.Models;

namespace CommanderGraphQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}