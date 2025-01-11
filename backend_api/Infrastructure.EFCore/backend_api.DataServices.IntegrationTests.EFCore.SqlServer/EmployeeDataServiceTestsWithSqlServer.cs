using backend_api.DataServices.EFCore;
using backend_api.Domains.Entities;
using backend_api.Domains.TestData;
using backend_api.EFCore.Setup;
using backend_api.Test.Core.TestBases;
using Xunit;

namespace backend_api.DataServices.IntegrationTests.EFCore.SqlServer;


public class EmployeeDataServiceTestsWithSqlServer : DataServiceSqlServerBaseIntegrationTests<Employee, int>, IClassFixture<DatabaseSetup>
{
    public EmployeeDataServiceTestsWithSqlServer() : base(new EmployeeDataService(TestDbContextFactory.CreateSqlServerDbContext()), x => x.Id, new EmployeeDataFactory())
    {

    }

}
