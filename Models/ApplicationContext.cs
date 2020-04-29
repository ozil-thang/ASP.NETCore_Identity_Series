using IdentitySeries.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace IdentitySeries.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}