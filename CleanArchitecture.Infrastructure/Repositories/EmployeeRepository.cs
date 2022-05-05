using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CleanArchitectureContext dataContext) 
            : base(dataContext) { }

        public async Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname)
        {
            return await _dataContext.Employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}
