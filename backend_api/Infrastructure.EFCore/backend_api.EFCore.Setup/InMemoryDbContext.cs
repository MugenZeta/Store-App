using backend_api.DataServices.EFCore.DataContext;
using Microsoft.EntityFrameworkCore;
using System;

namespace backend_api.EFCore.Setup;

public class InMemoryDbContext : AppDbContext
{
    private readonly bool _uniqueDbName;

    public InMemoryDbContext(bool uniqueDbName = false) : base(new DbContextOptionsBuilder<AppDbContext>().Options)
    {
        _uniqueDbName = uniqueDbName;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbName = "backend_api" + (_uniqueDbName ? Guid.NewGuid().ToString() : string.Empty);

        optionsBuilder.UseInMemoryDatabase(dbName);
    }
}