using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee>>
    {
    }
}
