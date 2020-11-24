using AutoMapper;
using OrganisationX.Dto;
using OrganisationX.Models;

namespace OrganisationX.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            // source -> target
            CreateMap<Employee, EmployeeReadDto>();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>();
        }
    }
}
