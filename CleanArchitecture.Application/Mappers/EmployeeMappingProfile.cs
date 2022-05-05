using AutoMapper;
using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Responses;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
