using OrganisationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
    }
}
