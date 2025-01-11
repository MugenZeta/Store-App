using backend_api.DataServices.EFCore.DataContext;

namespace backend_api.EFCore.Setup;

public static class TestDbContextFactory
{
    public static AppDbContext CreateInMemoryDbContext()
    {
        return new InMemoryDbContext(true);
    }

    public static AppDbContext CreateSqlServerDbContext()
    {
        return new SqlServerDbContext(
            "Server=(localdb)\\mssqllocaldb;Database=backend_api;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}