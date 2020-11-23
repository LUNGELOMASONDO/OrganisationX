using OrganisationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
