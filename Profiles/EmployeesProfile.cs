﻿using AutoMapper;
using OrganisationX.Dto;
using OrganisationX.Models;

namespace OrganisationX.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Employee, EmployeeReadDto>();
        }
    }
}