using backend_api.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend_api.DataServices.EFCore.DataContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().OwnsOne(c => c.Address);
    }
}