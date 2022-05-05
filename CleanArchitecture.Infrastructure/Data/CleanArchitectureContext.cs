using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data
{
    public class CleanArchitectureContext : DbContext
    {
        public CleanArchitectureContext(DbContextOptions<CleanArchitectureContext> options) 
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}