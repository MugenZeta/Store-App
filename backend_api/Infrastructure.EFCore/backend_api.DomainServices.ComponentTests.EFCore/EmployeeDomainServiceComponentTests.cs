using backend_api.DataServices.EFCore;
using backend_api.Domains.Entities;
using backend_api.Domains.TestData;
using backend_api.EFCore.Setup;
using backend_api.Test.Core.TestBases;

namespace backend_api.DomainServices.ComponentTests.EFCore;

public class EmployeeDomainServiceComponentTests : DomainServiceBaseComponentTests<Employee, int>
{
    public EmployeeDomainServiceComponentTests() :
        base(new EmployeeDomainService(Factory_DataService()), x => x.Id, new EmployeeDataFactory())
    {
    }

    static EmployeeDataService Factory_DataService()
    {
        EmployeeDataService employeeDataService =
            new EmployeeDataService(TestDbContextFactory.CreateInMemoryDbContext());

        return employeeDataService;
    }
}