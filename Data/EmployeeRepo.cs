using OrganisationX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrganisationX.Data
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext _context;

        public EmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee emp)
        {
            if(emp == null)
            {
                throw new ArgumentException(nameof(emp));
            }

            _context.Employees.Add(emp);
        }

        public Employee GetEmployeeByEmployeeNumber(int EmployeeNumber)
        {
            return _context.Employees.FirstOrDefault(p => p.EmployeeNumber == EmployeeNumber);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0 );
        }
    }
}
