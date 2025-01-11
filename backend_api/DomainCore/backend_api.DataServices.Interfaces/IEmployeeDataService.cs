using backend_api.Core.DataService;
using backend_api.Domains.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend_api.DataServices.Interfaces;

public interface IEmployeeDataService : IEntityDataService<Employee>
{
    Task<IList<Employee>> GetByFirstName(string firstName);
}