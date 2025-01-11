using backend_api.Core.DataService.EFCore;
using backend_api.DataServices.EFCore.DataContext;
using backend_api.DataServices.Interfaces;
using backend_api.Domains.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_api.DataServices.EFCore;

public class EmployeeDataService : EntityDataService<Employee>, IEmployeeDataService
{
    public EmployeeDataService(AppDbContext dbContext) : base(dbContext)
    {
    }

    public virtual async Task<IList<Employee>> GetByFirstName(string firstName)
    {
        return await DbContext.Set<Employee>().Where(x => x.FirstName.Contains(firstName)).ToListAsync();
    }
}