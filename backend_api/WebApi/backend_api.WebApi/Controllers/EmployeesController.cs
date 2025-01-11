using backend_api.Core.WebApi;
using backend_api.Domains.Entities;
using backend_api.DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace backend_api.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : WebApiControllerBase<Employee, int>
{
    public EmployeesController(EmployeeDomainService employeeDomainService) : base(employeeDomainService)
    {
    }
}