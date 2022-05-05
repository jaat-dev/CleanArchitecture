using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories.Base;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
    }
}
