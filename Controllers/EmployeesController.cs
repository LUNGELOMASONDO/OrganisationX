using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrganisationX.Models;
using OrganisationX.Data;
using AutoMapper;
using OrganisationX.Dto;

namespace OrganisationX.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _repo.GetEmployees();

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(employees));
        }

        [HttpGet("{EmployeeNumber}")]
        public ActionResult <EmployeeReadDto> GetEmployeeById(int EmployeeNumber)
        {
            var employee = _repo.GetEmployeeByEmployeeNumber(EmployeeNumber);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<EmployeeReadDto>(employee));
        }
    }
}
