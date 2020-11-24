using OrganisationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Data
{
    public interface IEmployeeRepo
    {
        bool SaveChanges();

        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByEmployeeNumber(int EmployeeNumber);
        void CreateEmployee(Employee emp);
    }
}
