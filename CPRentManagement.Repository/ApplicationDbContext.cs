using CPRentManagement.Domain.Models;
using CPRentManagement.Repository.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CPRentManagement.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyEntityTypeConfiguration).Assembly);
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
