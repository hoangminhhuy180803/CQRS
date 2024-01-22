

using Domain.model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings and relationships
        }
    }
}
