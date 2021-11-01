using CPRentManagement.API.DataAccess.EntityConfiguration;
using CPRentManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CPRentManagement.API.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
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
