using CleanArchitecture.Application.Queries;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Handlers.QueryHandlers
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetAllEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;
        }

        public async Task<List<Employee>> Handle(
            GetAllEmployeeQuery request, 
            CancellationToken cancellationToken)
        {
            return (List<Employee>)await _employeeRepo.GetAllAsync();
        }
    }
}
