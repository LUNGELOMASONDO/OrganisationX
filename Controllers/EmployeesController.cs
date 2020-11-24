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
       
        public EmployeesController(IEmployeeRepo repo)
        {
            _repo = repo;
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

        [HttpGet("{EmployeeNumber}")]
        public ActionResult <Employee> GetEmployeeById(int EmployeeNumber)
        {
            var employee = _repo.GetEmployeeByEmployeeNumber(EmployeeNumber);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
    }
}
