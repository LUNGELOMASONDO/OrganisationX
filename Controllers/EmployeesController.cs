using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrganisationX.Models;
using OrganisationX.Data;

namespace OrganisationX.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _repo;
       
        public EmployeesController(IEmployeeRepo employee)
        {
            _repo = employee;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            var employees = _repo.GetEmployees();

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult <Employee> GetEmployeeById(int id)
        {
            var employee = _repo.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
