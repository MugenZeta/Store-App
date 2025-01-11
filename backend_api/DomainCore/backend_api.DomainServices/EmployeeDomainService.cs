using backend_api.Core.DomainService;
using backend_api.DataServices.Interfaces;
using backend_api.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend_api.DomainServices;

public class EmployeeDomainService : DomainService<Employee, int>
{
    private readonly IEmployeeDataService _employeeDataService;

    public EmployeeDomainService(IEmployeeDataService employeeDataService) : base(employeeDataService)
    {
        _employeeDataService = employeeDataService;
    }

    public virtual async Task<IList<Employee>> GetByFirstName(string firstName)
    {
        return await _employeeDataService.GetByFirstName(firstName);
    }
}