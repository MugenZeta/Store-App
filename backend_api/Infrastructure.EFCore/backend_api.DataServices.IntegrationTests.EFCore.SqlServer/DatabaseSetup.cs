using backend_api.EFCore.Setup;
using System;

namespace backend_api.DataServices.IntegrationTests.EFCore.SqlServer;

public class DatabaseSetup : IDisposable
{
    public DatabaseSetup()
    {
        var db = TestDbContextFactory.CreateSqlServerDbContext();
        DbContextDataInitializer.Initialize(db);
    }

    public void Dispose()
    {
        // ... clean up test data from the database ...
    }

}
