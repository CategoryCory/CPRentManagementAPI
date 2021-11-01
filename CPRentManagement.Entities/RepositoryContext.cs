using CPRentManagement.Entities.EntityConfiguration;
using CPRentManagement.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace CPRentManagement.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyEntityTypeConfiguration).Assembly);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
